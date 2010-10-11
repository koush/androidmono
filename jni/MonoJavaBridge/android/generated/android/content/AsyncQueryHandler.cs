namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.AsyncQueryHandler_))]
	public abstract partial class AsyncQueryHandler : android.os.Handler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AsyncQueryHandler()
		{
			InitJNI();
		}
		protected AsyncQueryHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		protected sealed partial class WorkerArgs : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static WorkerArgs()
			{
				InitJNI();
			}
			internal WorkerArgs(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.FieldId _uri1062;
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
			internal static global::MonoJavaBridge.FieldId _handler1063;
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
			internal static global::MonoJavaBridge.FieldId _projection1064;
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
			internal static global::MonoJavaBridge.FieldId _selection1065;
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
			internal static global::MonoJavaBridge.FieldId _selectionArgs1066;
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
			internal static global::MonoJavaBridge.FieldId _orderBy1067;
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
			internal static global::MonoJavaBridge.FieldId _result1068;
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
			internal static global::MonoJavaBridge.FieldId _cookie1069;
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
			internal static global::MonoJavaBridge.FieldId _values1070;
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.AsyncQueryHandler.WorkerArgs.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AsyncQueryHandler$WorkerArgs"));
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class WorkerHandler : android.os.Handler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static WorkerHandler()
			{
				InitJNI();
			}
			protected WorkerHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _handleMessage1071;
			public override void handleMessage(android.os.Message arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.WorkerHandler._handleMessage1071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.WorkerHandler.staticClass, global::android.content.AsyncQueryHandler.WorkerHandler._handleMessage1071, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _WorkerHandler1072;
			public WorkerHandler(android.content.AsyncQueryHandler arg0, android.os.Looper arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.AsyncQueryHandler.WorkerHandler.staticClass, global::android.content.AsyncQueryHandler.WorkerHandler._WorkerHandler1072, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.AsyncQueryHandler.WorkerHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AsyncQueryHandler$WorkerHandler"));
				global::android.content.AsyncQueryHandler.WorkerHandler._handleMessage1071 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.WorkerHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V");
				global::android.content.AsyncQueryHandler.WorkerHandler._WorkerHandler1072 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.WorkerHandler.staticClass, "<init>", "(Landroid/content/AsyncQueryHandler;Landroid/os/Looper;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _handleMessage1073;
		public override void handleMessage(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._handleMessage1073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._handleMessage1073, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createHandler1074;
		protected virtual global::android.os.Handler createHandler(android.os.Looper arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._createHandler1074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Handler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._createHandler1074, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Handler;
		}
		internal static global::MonoJavaBridge.MethodId _startQuery1075;
		public virtual void startQuery(int arg0, java.lang.Object arg1, android.net.Uri arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String[] arg5, java.lang.String arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._startQuery1075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._startQuery1075, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _cancelOperation1076;
		public virtual void cancelOperation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._cancelOperation1076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._cancelOperation1076, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startInsert1077;
		public virtual void startInsert(int arg0, java.lang.Object arg1, android.net.Uri arg2, android.content.ContentValues arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._startInsert1077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._startInsert1077, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _startUpdate1078;
		public virtual void startUpdate(int arg0, java.lang.Object arg1, android.net.Uri arg2, android.content.ContentValues arg3, java.lang.String arg4, java.lang.String[] arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._startUpdate1078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._startUpdate1078, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _startDelete1079;
		public virtual void startDelete(int arg0, java.lang.Object arg1, android.net.Uri arg2, java.lang.String arg3, java.lang.String[] arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._startDelete1079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._startDelete1079, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onQueryComplete1080;
		protected virtual void onQueryComplete(int arg0, java.lang.Object arg1, android.database.Cursor arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._onQueryComplete1080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._onQueryComplete1080, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onInsertComplete1081;
		protected virtual void onInsertComplete(int arg0, java.lang.Object arg1, android.net.Uri arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._onInsertComplete1081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._onInsertComplete1081, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onUpdateComplete1082;
		protected virtual void onUpdateComplete(int arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._onUpdateComplete1082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._onUpdateComplete1082, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onDeleteComplete1083;
		protected virtual void onDeleteComplete(int arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._onDeleteComplete1083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._onDeleteComplete1083, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _AsyncQueryHandler1084;
		public AsyncQueryHandler(android.content.ContentResolver arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._AsyncQueryHandler1084, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.AsyncQueryHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AsyncQueryHandler"));
			global::android.content.AsyncQueryHandler._handleMessage1073 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V");
			global::android.content.AsyncQueryHandler._createHandler1074 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "createHandler", "(Landroid/os/Looper;)Landroid/os/Handler;");
			global::android.content.AsyncQueryHandler._startQuery1075 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "startQuery", "(ILjava/lang/Object;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.AsyncQueryHandler._cancelOperation1076 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "cancelOperation", "(I)V");
			global::android.content.AsyncQueryHandler._startInsert1077 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "startInsert", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;)V");
			global::android.content.AsyncQueryHandler._startUpdate1078 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "startUpdate", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)V");
			global::android.content.AsyncQueryHandler._startDelete1079 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "startDelete", "(ILjava/lang/Object;Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)V");
			global::android.content.AsyncQueryHandler._onQueryComplete1080 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "onQueryComplete", "(ILjava/lang/Object;Landroid/database/Cursor;)V");
			global::android.content.AsyncQueryHandler._onInsertComplete1081 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "onInsertComplete", "(ILjava/lang/Object;Landroid/net/Uri;)V");
			global::android.content.AsyncQueryHandler._onUpdateComplete1082 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "onUpdateComplete", "(ILjava/lang/Object;I)V");
			global::android.content.AsyncQueryHandler._onDeleteComplete1083 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "onDeleteComplete", "(ILjava/lang/Object;I)V");
			global::android.content.AsyncQueryHandler._AsyncQueryHandler1084 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "<init>", "(Landroid/content/ContentResolver;)V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.AsyncQueryHandler))]
	public sealed partial class AsyncQueryHandler_ : android.content.AsyncQueryHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AsyncQueryHandler_()
		{
			InitJNI();
		}
		internal AsyncQueryHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.AsyncQueryHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AsyncQueryHandler"));
		}
	}
}
