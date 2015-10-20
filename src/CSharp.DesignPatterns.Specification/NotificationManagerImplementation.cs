using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace CSharp.DesignPatterns.Specification {
    public interface INotificationManager {
        void Add(Notification notification);
        IQueryable<Notification> Query();
        void Flush();
    }

    public class Notification {

    }

    public interface IStorage {
        void Store(object obj);
    }
    
    public class NotificationManager : INotificationManager, IDisposable {
        #region IDisposable Implementation

        private bool _disposed;

        ~NotificationManager() {
            Dispose(false);
        }

        protected virtual void Dispose(bool disposing) {
            if (_disposed) { return; }
            if (disposing) {
                // Before dispose, flush.
                Flush();
                
                // Dispose managed resources
            }

            // Dispose unmanaged resources

            _disposed = true;
        }

        public void Dispose() {
            GC.SuppressFinalize(this);
            Dispose(true);
        }

        protected void EnsureAccessBlockedAfterDispose() {
            if (_disposed) {
                throw new ObjectDisposedException(GetType().Name);
            }
        }

        #endregion

        #region INotificationManager Implementation

        private static readonly object SyncLock = new object();
        private readonly IList<Notification> _notifications;
        private readonly Timer _timer;
        private readonly IStorage _storage;
        private bool _dirty;

        public NotificationManager(int flushTimeout, IStorage storage) {
            _notifications = new List<Notification>();
            _timer = new Timer(TimerCallbackHandler, null, Timeout.InfiniteTimeSpan, TimeSpan.FromSeconds(flushTimeout));
            _storage = storage;
        }

        private void TimerCallbackHandler(object state) {
            Flush();
        }

        public void Add(Notification notification) {
            lock (SyncLock) {
                if (!_notifications.Contains(notification)) {
                    _dirty = true;
                    _notifications.Add(notification);
                }
            }
        }

        public IQueryable<Notification> Query() {
            return _notifications.AsQueryable();
        }

        public void Flush() {
            if (!_dirty) { return; }

            lock (SyncLock) {
                _storage.Store(_notifications);
            }
        }

        #endregion
    }
}