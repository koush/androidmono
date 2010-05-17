namespace android.content 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AsyncQueryHandler : android.os.Handler
	{ 
		internal new static global::java.lang.Class staticClass; 
		static AsyncQueryHandler() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.AsyncQueryHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AsyncQueryHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected sealed class WorkerArgs : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static WorkerArgs() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.AsyncQueryHandler.WorkerArgs), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.content.AsyncQueryHandler.WorkerArgs(@__env); 
				} 
			} 
			internal WorkerArgs(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _uri902; 
			public android.net.Uri uri
			{ 
				get 
				{ 
					return default(android.net.Uri); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _handler903; 
			public android.os.Handler handler
			{ 
				get 
				{ 
					return default(android.os.Handler); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _projection904; 
			public java.lang.String[] projection
			{ 
				get 
				{ 
					return default(java.lang.String[]); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _selection905; 
			public java.lang.String selection
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _selectionArgs906; 
			public java.lang.String[] selectionArgs
			{ 
				get 
				{ 
					return default(java.lang.String[]); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _orderBy907; 
			public java.lang.String orderBy
			{ 
				get 
				{ 
					return default(java.lang.String); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _result908; 
			public java.lang.Object result
			{ 
				get 
				{ 
					return default(java.lang.Object); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _cookie909; 
			public java.lang.Object cookie
			{ 
				get 
				{ 
					return default(java.lang.Object); 
				} 
				set 
				{ 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _values910; 
			public android.content.ContentValues values
			{ 
				get 
				{ 
					return default(android.content.ContentValues); 
				} 
				set 
				{ 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.AsyncQueryHandler.WorkerArgs.staticClass = @__class; 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected class WorkerHandler : android.os.Handler
		{ 
			internal new static global::java.lang.Class staticClass; 
			static WorkerHandler() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.AsyncQueryHandler.WorkerHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.content.AsyncQueryHandler.WorkerHandler(@__env); 
				} 
			} 
			protected WorkerHandler(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _handleMessage911; 
			public override void handleMessage(android.os.Message arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.content.AsyncQueryHandler.WorkerHandler)) 
					@__env.CallVoidMethod(this, _handleMessage911, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.content.AsyncQueryHandler.WorkerHandler.staticClass, _handleMessage911, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _WorkerHandler912; 
			public WorkerHandler(android.content.AsyncQueryHandler arg0, android.os.Looper arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.content.AsyncQueryHandler.WorkerHandler.staticClass, _WorkerHandler912, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.content.AsyncQueryHandler.WorkerHandler.staticClass = @__class; 
				global::android.content.AsyncQueryHandler.WorkerHandler._handleMessage911 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.WorkerHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V"); 
				global::android.content.AsyncQueryHandler.WorkerHandler._WorkerHandler912 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.WorkerHandler.staticClass, "<init>", "(Landroid/content/AsyncQueryHandler;Landroid/os/Looper;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _handleMessage913; 
		public override void handleMessage(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.AsyncQueryHandler)) 
				@__env.CallVoidMethod(this, _handleMessage913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.AsyncQueryHandler.staticClass, _handleMessage913, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createHandler914; 
		protected virtual android.os.Handler createHandler(android.os.Looper arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.AsyncQueryHandler)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Handler>(@__env, @__env.CallObjectMethodPtr(this, _createHandler914, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Handler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.AsyncQueryHandler.staticClass, _createHandler914, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startQuery915; 
		public virtual void startQuery(int arg0, java.lang.Object arg1, android.net.Uri arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String[] arg5, java.lang.String arg6) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.AsyncQueryHandler)) 
				@__env.CallVoidMethod(this, _startQuery915, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.AsyncQueryHandler.staticClass, _startQuery915, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancelOperation916; 
		public virtual void cancelOperation(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.AsyncQueryHandler)) 
				@__env.CallVoidMethod(this, _cancelOperation916, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.AsyncQueryHandler.staticClass, _cancelOperation916, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startInsert917; 
		public virtual void startInsert(int arg0, java.lang.Object arg1, android.net.Uri arg2, android.content.ContentValues arg3) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.AsyncQueryHandler)) 
				@__env.CallVoidMethod(this, _startInsert917, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.AsyncQueryHandler.staticClass, _startInsert917, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startUpdate918; 
		public virtual void startUpdate(int arg0, java.lang.Object arg1, android.net.Uri arg2, android.content.ContentValues arg3, java.lang.String arg4, java.lang.String[] arg5) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.AsyncQueryHandler)) 
				@__env.CallVoidMethod(this, _startUpdate918, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg5)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.AsyncQueryHandler.staticClass, _startUpdate918, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg5)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _startDelete919; 
		public virtual void startDelete(int arg0, java.lang.Object arg1, android.net.Uri arg2, java.lang.String arg3, java.lang.String[] arg4) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.AsyncQueryHandler)) 
				@__env.CallVoidMethod(this, _startDelete919, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.AsyncQueryHandler.staticClass, _startDelete919, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onQueryComplete920; 
		protected virtual void onQueryComplete(int arg0, java.lang.Object arg1, android.database.Cursor arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.AsyncQueryHandler)) 
				@__env.CallVoidMethod(this, _onQueryComplete920, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.AsyncQueryHandler.staticClass, _onQueryComplete920, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onInsertComplete921; 
		protected virtual void onInsertComplete(int arg0, java.lang.Object arg1, android.net.Uri arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.AsyncQueryHandler)) 
				@__env.CallVoidMethod(this, _onInsertComplete921, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.AsyncQueryHandler.staticClass, _onInsertComplete921, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateComplete922; 
		protected virtual void onUpdateComplete(int arg0, java.lang.Object arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.AsyncQueryHandler)) 
				@__env.CallVoidMethod(this, _onUpdateComplete922, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.AsyncQueryHandler.staticClass, _onUpdateComplete922, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onDeleteComplete923; 
		protected virtual void onDeleteComplete(int arg0, java.lang.Object arg1, int arg2) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.AsyncQueryHandler)) 
				@__env.CallVoidMethod(this, _onDeleteComplete923, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.AsyncQueryHandler.staticClass, _onDeleteComplete923, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AsyncQueryHandler924; 
		public AsyncQueryHandler(android.content.ContentResolver arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.AsyncQueryHandler.staticClass, _AsyncQueryHandler924, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.AsyncQueryHandler.staticClass = @__class; 
			global::android.content.AsyncQueryHandler._handleMessage913 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V"); 
			global::android.content.AsyncQueryHandler._createHandler914 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "createHandler", "(Landroid/os/Looper;)Landroid/os/Handler;"); 
			global::android.content.AsyncQueryHandler._startQuery915 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "startQuery", "(ILjava/lang/Object;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.content.AsyncQueryHandler._cancelOperation916 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "cancelOperation", "(I)V"); 
			global::android.content.AsyncQueryHandler._startInsert917 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "startInsert", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;)V"); 
			global::android.content.AsyncQueryHandler._startUpdate918 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "startUpdate", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)V"); 
			global::android.content.AsyncQueryHandler._startDelete919 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "startDelete", "(ILjava/lang/Object;Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)V"); 
			global::android.content.AsyncQueryHandler._onQueryComplete920 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "onQueryComplete", "(ILjava/lang/Object;Landroid/database/Cursor;)V"); 
			global::android.content.AsyncQueryHandler._onInsertComplete921 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "onInsertComplete", "(ILjava/lang/Object;Landroid/net/Uri;)V"); 
			global::android.content.AsyncQueryHandler._onUpdateComplete922 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "onUpdateComplete", "(ILjava/lang/Object;I)V"); 
			global::android.content.AsyncQueryHandler._onDeleteComplete923 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "onDeleteComplete", "(ILjava/lang/Object;I)V"); 
			global::android.content.AsyncQueryHandler._AsyncQueryHandler924 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "<init>", "(Landroid/content/ContentResolver;)V"); 
		} 
	} 
} 
