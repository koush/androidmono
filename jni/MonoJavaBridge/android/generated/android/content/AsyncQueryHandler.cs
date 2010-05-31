namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public abstract class AsyncQueryHandler : android.os.Handler
	{
		internal new static global::java.lang.Class staticClass;
		static AsyncQueryHandler()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.AsyncQueryHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.AsyncQueryHandler.WorkerArgs), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.FieldId _uri915;
			public global::android.net.Uri uri
			{
				get
				{
					return default(global::android.net.Uri);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _handler916;
			public global::android.os.Handler handler
			{
				get
				{
					return default(global::android.os.Handler);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _projection917;
			public global::java.lang.String[] projection
			{
				get
				{
					return default(global::java.lang.String[]);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _selection918;
			public global::java.lang.String selection
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _selectionArgs919;
			public global::java.lang.String[] selectionArgs
			{
				get
				{
					return default(global::java.lang.String[]);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _orderBy920;
			public global::java.lang.String orderBy
			{
				get
				{
					return default(global::java.lang.String);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _result921;
			public global::java.lang.Object result
			{
				get
				{
					return default(global::java.lang.Object);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _cookie922;
			public global::java.lang.Object cookie
			{
				get
				{
					return default(global::java.lang.Object);
				}
				set
				{
				}
			}
			internal static global::net.sf.jni4net.jni.FieldId _values923;
			public global::android.content.ContentValues values
			{
				get
				{
					return default(global::android.content.ContentValues);
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.AsyncQueryHandler.WorkerHandler), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
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
			internal static global::net.sf.jni4net.jni.MethodId _handleMessage924;
			public override void handleMessage(android.os.Message arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.content.AsyncQueryHandler.WorkerHandler._handleMessage924, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.content.AsyncQueryHandler.WorkerHandler.staticClass, global::android.content.AsyncQueryHandler.WorkerHandler._handleMessage924, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			internal static global::net.sf.jni4net.jni.MethodId _WorkerHandler925;
			public WorkerHandler(android.content.AsyncQueryHandler arg0, android.os.Looper arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.content.AsyncQueryHandler.WorkerHandler.staticClass, global::android.content.AsyncQueryHandler.WorkerHandler._WorkerHandler925, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.content.AsyncQueryHandler.WorkerHandler.staticClass = @__class;
				global::android.content.AsyncQueryHandler.WorkerHandler._handleMessage924 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.WorkerHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V");
				global::android.content.AsyncQueryHandler.WorkerHandler._WorkerHandler925 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.WorkerHandler.staticClass, "<init>", "(Landroid/content/AsyncQueryHandler;Landroid/os/Looper;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _handleMessage926;
		public override void handleMessage(android.os.Message arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.AsyncQueryHandler._handleMessage926, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._handleMessage926, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _createHandler927;
		protected virtual global::android.os.Handler createHandler(android.os.Looper arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Handler>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.AsyncQueryHandler._createHandler927, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Handler>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._createHandler927, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startQuery928;
		public virtual void startQuery(int arg0, java.lang.Object arg1, android.net.Uri arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String[] arg5, java.lang.String arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.AsyncQueryHandler._startQuery928, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._startQuery928, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6));
		}
		internal static global::net.sf.jni4net.jni.MethodId _cancelOperation929;
		public virtual void cancelOperation(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.AsyncQueryHandler._cancelOperation929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._cancelOperation929, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startInsert930;
		public virtual void startInsert(int arg0, java.lang.Object arg1, android.net.Uri arg2, android.content.ContentValues arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.AsyncQueryHandler._startInsert930, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._startInsert930, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startUpdate931;
		public virtual void startUpdate(int arg0, java.lang.Object arg1, android.net.Uri arg2, android.content.ContentValues arg3, java.lang.String arg4, java.lang.String[] arg5) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.AsyncQueryHandler._startUpdate931, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg5));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._startUpdate931, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg5));
		}
		internal static global::net.sf.jni4net.jni.MethodId _startDelete932;
		public virtual void startDelete(int arg0, java.lang.Object arg1, android.net.Uri arg2, java.lang.String arg3, java.lang.String[] arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.AsyncQueryHandler._startDelete932, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._startDelete932, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onQueryComplete933;
		protected virtual void onQueryComplete(int arg0, java.lang.Object arg1, android.database.Cursor arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.AsyncQueryHandler._onQueryComplete933, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._onQueryComplete933, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onInsertComplete934;
		protected virtual void onInsertComplete(int arg0, java.lang.Object arg1, android.net.Uri arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.AsyncQueryHandler._onInsertComplete934, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._onInsertComplete934, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onUpdateComplete935;
		protected virtual void onUpdateComplete(int arg0, java.lang.Object arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.AsyncQueryHandler._onUpdateComplete935, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._onUpdateComplete935, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onDeleteComplete936;
		protected virtual void onDeleteComplete(int arg0, java.lang.Object arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.AsyncQueryHandler._onDeleteComplete936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._onDeleteComplete936, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _AsyncQueryHandler937;
		public AsyncQueryHandler(android.content.ContentResolver arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._AsyncQueryHandler937, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.AsyncQueryHandler.staticClass = @__class;
			global::android.content.AsyncQueryHandler._handleMessage926 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V");
			global::android.content.AsyncQueryHandler._createHandler927 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "createHandler", "(Landroid/os/Looper;)Landroid/os/Handler;");
			global::android.content.AsyncQueryHandler._startQuery928 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "startQuery", "(ILjava/lang/Object;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.AsyncQueryHandler._cancelOperation929 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "cancelOperation", "(I)V");
			global::android.content.AsyncQueryHandler._startInsert930 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "startInsert", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;)V");
			global::android.content.AsyncQueryHandler._startUpdate931 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "startUpdate", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)V");
			global::android.content.AsyncQueryHandler._startDelete932 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "startDelete", "(ILjava/lang/Object;Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)V");
			global::android.content.AsyncQueryHandler._onQueryComplete933 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "onQueryComplete", "(ILjava/lang/Object;Landroid/database/Cursor;)V");
			global::android.content.AsyncQueryHandler._onInsertComplete934 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "onInsertComplete", "(ILjava/lang/Object;Landroid/net/Uri;)V");
			global::android.content.AsyncQueryHandler._onUpdateComplete935 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "onUpdateComplete", "(ILjava/lang/Object;I)V");
			global::android.content.AsyncQueryHandler._onDeleteComplete936 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "onDeleteComplete", "(ILjava/lang/Object;I)V");
			global::android.content.AsyncQueryHandler._AsyncQueryHandler937 = @__env.GetMethodID(global::android.content.AsyncQueryHandler.staticClass, "<init>", "(Landroid/content/ContentResolver;)V");
		}
	}
}
