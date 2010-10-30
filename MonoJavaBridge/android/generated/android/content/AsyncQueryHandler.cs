namespace android.content
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.content.AsyncQueryHandler_))]
	public abstract partial class AsyncQueryHandler : android.os.Handler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AsyncQueryHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		protected sealed partial class WorkerArgs : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal WorkerArgs(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.FieldId _uri2567;
			public global::android.net.Uri uri
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _uri2567)) as android.net.Uri;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _handler2568;
			public global::android.os.Handler handler
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _handler2568)) as android.os.Handler;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _projection2569;
			public global::java.lang.String[] projection
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _projection2569)) as java.lang.String[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _selection2570;
			public global::java.lang.String selection
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _selection2570)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _selectionArgs2571;
			public global::java.lang.String[] selectionArgs
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _selectionArgs2571)) as java.lang.String[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _orderBy2572;
			public global::java.lang.String orderBy
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _orderBy2572)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _result2573;
			public global::java.lang.Object result
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _result2573)) as java.lang.Object;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _cookie2574;
			public global::java.lang.Object cookie
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _cookie2574)) as java.lang.Object;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _values2575;
			public global::android.content.ContentValues values
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ContentValues>(@__env.GetObjectField(this.JvmHandle, _values2575)) as android.content.ContentValues;
				}
				set
				{
				}
			}
			static WorkerArgs()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.AsyncQueryHandler.WorkerArgs.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AsyncQueryHandler$WorkerArgs"));
				global::android.content.AsyncQueryHandler.WorkerArgs._uri2567 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "uri", "Landroid/net/Uri;");
				global::android.content.AsyncQueryHandler.WorkerArgs._handler2568 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "handler", "Landroid/os/Handler;");
				global::android.content.AsyncQueryHandler.WorkerArgs._projection2569 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "projection", "[Ljava/lang/String;");
				global::android.content.AsyncQueryHandler.WorkerArgs._selection2570 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "selection", "Ljava/lang/String;");
				global::android.content.AsyncQueryHandler.WorkerArgs._selectionArgs2571 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "selectionArgs", "[Ljava/lang/String;");
				global::android.content.AsyncQueryHandler.WorkerArgs._orderBy2572 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "orderBy", "Ljava/lang/String;");
				global::android.content.AsyncQueryHandler.WorkerArgs._result2573 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "result", "Ljava/lang/Object;");
				global::android.content.AsyncQueryHandler.WorkerArgs._cookie2574 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "cookie", "Ljava/lang/Object;");
				global::android.content.AsyncQueryHandler.WorkerArgs._values2575 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "values", "Landroid/content/ContentValues;");
			}
			internal static void InitJNI()
			{
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class WorkerHandler : android.os.Handler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected WorkerHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _handleMessage2576;
			public override void handleMessage(android.os.Message arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.WorkerHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V", ref global::android.content.AsyncQueryHandler.WorkerHandler._handleMessage2576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _WorkerHandler2577;
			public WorkerHandler(android.content.AsyncQueryHandler arg0, android.os.Looper arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.AsyncQueryHandler.WorkerHandler._WorkerHandler2577.native == global::System.IntPtr.Zero)
					global::android.content.AsyncQueryHandler.WorkerHandler._WorkerHandler2577 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.WorkerHandler.staticClass, "<init>", "(Landroid/content/AsyncQueryHandler;Landroid/os/Looper;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.AsyncQueryHandler.WorkerHandler.staticClass, global::android.content.AsyncQueryHandler.WorkerHandler._WorkerHandler2577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			static WorkerHandler()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.AsyncQueryHandler.WorkerHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AsyncQueryHandler$WorkerHandler"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _handleMessage2578;
		public override void handleMessage(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V", ref global::android.content.AsyncQueryHandler._handleMessage2578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createHandler2579;
		protected virtual global::android.os.Handler createHandler(android.os.Looper arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.AsyncQueryHandler.staticClass, "createHandler", "(Landroid/os/Looper;)Landroid/os/Handler;", ref global::android.content.AsyncQueryHandler._createHandler2579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Handler;
		}
		internal static global::MonoJavaBridge.MethodId _startQuery2580;
		public virtual void startQuery(int arg0, java.lang.Object arg1, android.net.Uri arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String[] arg5, java.lang.String arg6)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "startQuery", "(ILjava/lang/Object;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)V", ref global::android.content.AsyncQueryHandler._startQuery2580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _cancelOperation2581;
		public virtual void cancelOperation(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "cancelOperation", "(I)V", ref global::android.content.AsyncQueryHandler._cancelOperation2581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startInsert2582;
		public virtual void startInsert(int arg0, java.lang.Object arg1, android.net.Uri arg2, android.content.ContentValues arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "startInsert", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;)V", ref global::android.content.AsyncQueryHandler._startInsert2582, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _startUpdate2583;
		public virtual void startUpdate(int arg0, java.lang.Object arg1, android.net.Uri arg2, android.content.ContentValues arg3, java.lang.String arg4, java.lang.String[] arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "startUpdate", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)V", ref global::android.content.AsyncQueryHandler._startUpdate2583, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _startDelete2584;
		public virtual void startDelete(int arg0, java.lang.Object arg1, android.net.Uri arg2, java.lang.String arg3, java.lang.String[] arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "startDelete", "(ILjava/lang/Object;Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)V", ref global::android.content.AsyncQueryHandler._startDelete2584, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onQueryComplete2585;
		protected virtual void onQueryComplete(int arg0, java.lang.Object arg1, android.database.Cursor arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "onQueryComplete", "(ILjava/lang/Object;Landroid/database/Cursor;)V", ref global::android.content.AsyncQueryHandler._onQueryComplete2585, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onInsertComplete2586;
		protected virtual void onInsertComplete(int arg0, java.lang.Object arg1, android.net.Uri arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "onInsertComplete", "(ILjava/lang/Object;Landroid/net/Uri;)V", ref global::android.content.AsyncQueryHandler._onInsertComplete2586, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onUpdateComplete2587;
		protected virtual void onUpdateComplete(int arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "onUpdateComplete", "(ILjava/lang/Object;I)V", ref global::android.content.AsyncQueryHandler._onUpdateComplete2587, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onDeleteComplete2588;
		protected virtual void onDeleteComplete(int arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "onDeleteComplete", "(ILjava/lang/Object;I)V", ref global::android.content.AsyncQueryHandler._onDeleteComplete2588, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _AsyncQueryHandler2589;
		public AsyncQueryHandler(android.content.ContentResolver arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.AsyncQueryHandler._AsyncQueryHandler2589.native == global::System.IntPtr.Zero)
				global::android.content.AsyncQueryHandler._AsyncQueryHandler2589 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "<init>", "(Landroid/content/ContentResolver;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._AsyncQueryHandler2589, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AsyncQueryHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.AsyncQueryHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AsyncQueryHandler"));
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.content.AsyncQueryHandler))]
	internal sealed partial class AsyncQueryHandler_ : android.content.AsyncQueryHandler
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AsyncQueryHandler_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		static AsyncQueryHandler_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.AsyncQueryHandler_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AsyncQueryHandler"));
		}
		internal static void InitJNI()
		{
		}
	}
}
