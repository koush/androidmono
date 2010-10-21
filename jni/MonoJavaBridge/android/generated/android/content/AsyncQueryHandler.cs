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
			internal static global::MonoJavaBridge.FieldId _uri2559;
			public global::android.net.Uri uri
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _uri2559)) as android.net.Uri;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _handler2560;
			public global::android.os.Handler handler
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _handler2560)) as android.os.Handler;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _projection2561;
			public global::java.lang.String[] projection
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _projection2561)) as java.lang.String[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _selection2562;
			public global::java.lang.String selection
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _selection2562)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _selectionArgs2563;
			public global::java.lang.String[] selectionArgs
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _selectionArgs2563)) as java.lang.String[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _orderBy2564;
			public global::java.lang.String orderBy
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _orderBy2564)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _result2565;
			public global::java.lang.Object result
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _result2565)) as java.lang.Object;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _cookie2566;
			public global::java.lang.Object cookie
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _cookie2566)) as java.lang.Object;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _values2567;
			public global::android.content.ContentValues values
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _values2567)) as android.content.ContentValues;
				}
				set
				{
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.AsyncQueryHandler.WorkerArgs.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AsyncQueryHandler$WorkerArgs"));
				global::android.content.AsyncQueryHandler.WorkerArgs._uri2559 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "uri", "Landroid/net/Uri;");
				global::android.content.AsyncQueryHandler.WorkerArgs._handler2560 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "handler", "Landroid/os/Handler;");
				global::android.content.AsyncQueryHandler.WorkerArgs._projection2561 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "projection", "[Ljava/lang/String;");
				global::android.content.AsyncQueryHandler.WorkerArgs._selection2562 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "selection", "Ljava/lang/String;");
				global::android.content.AsyncQueryHandler.WorkerArgs._selectionArgs2563 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "selectionArgs", "[Ljava/lang/String;");
				global::android.content.AsyncQueryHandler.WorkerArgs._orderBy2564 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "orderBy", "Ljava/lang/String;");
				global::android.content.AsyncQueryHandler.WorkerArgs._result2565 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "result", "Ljava/lang/Object;");
				global::android.content.AsyncQueryHandler.WorkerArgs._cookie2566 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "cookie", "Ljava/lang/Object;");
				global::android.content.AsyncQueryHandler.WorkerArgs._values2567 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "values", "Landroid/content/ContentValues;");
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
			internal static global::MonoJavaBridge.MethodId _handleMessage2568;
			public override void handleMessage(android.os.Message arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.WorkerHandler._handleMessage2568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.WorkerHandler.staticClass, global::android.content.AsyncQueryHandler.WorkerHandler._handleMessage2568, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			internal static global::MonoJavaBridge.MethodId _WorkerHandler2569;
			public WorkerHandler(android.content.AsyncQueryHandler arg0, android.os.Looper arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.AsyncQueryHandler.WorkerHandler.staticClass, global::android.content.AsyncQueryHandler.WorkerHandler._WorkerHandler2569, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.AsyncQueryHandler.WorkerHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AsyncQueryHandler$WorkerHandler"));
				global::android.content.AsyncQueryHandler.WorkerHandler._handleMessage2568 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.WorkerHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V");
				global::android.content.AsyncQueryHandler.WorkerHandler._WorkerHandler2569 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.WorkerHandler.staticClass, "<init>", "(Landroid/content/AsyncQueryHandler;Landroid/os/Looper;)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _handleMessage2570;
		public override void handleMessage(android.os.Message arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._handleMessage2570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._handleMessage2570, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _createHandler2571;
		protected virtual global::android.os.Handler createHandler(android.os.Looper arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._createHandler2571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Handler;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._createHandler2571, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.Handler;
		}
		internal static global::MonoJavaBridge.MethodId _startQuery2572;
		public virtual void startQuery(int arg0, java.lang.Object arg1, android.net.Uri arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String[] arg5, java.lang.String arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._startQuery2572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._startQuery2572, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		internal static global::MonoJavaBridge.MethodId _cancelOperation2573;
		public virtual void cancelOperation(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._cancelOperation2573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._cancelOperation2573, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _startInsert2574;
		public virtual void startInsert(int arg0, java.lang.Object arg1, android.net.Uri arg2, android.content.ContentValues arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._startInsert2574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._startInsert2574, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _startUpdate2575;
		public virtual void startUpdate(int arg0, java.lang.Object arg1, android.net.Uri arg2, android.content.ContentValues arg3, java.lang.String arg4, java.lang.String[] arg5) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._startUpdate2575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._startUpdate2575, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		internal static global::MonoJavaBridge.MethodId _startDelete2576;
		public virtual void startDelete(int arg0, java.lang.Object arg1, android.net.Uri arg2, java.lang.String arg3, java.lang.String[] arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._startDelete2576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._startDelete2576, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _onQueryComplete2577;
		protected virtual void onQueryComplete(int arg0, java.lang.Object arg1, android.database.Cursor arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._onQueryComplete2577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._onQueryComplete2577, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onInsertComplete2578;
		protected virtual void onInsertComplete(int arg0, java.lang.Object arg1, android.net.Uri arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._onInsertComplete2578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._onInsertComplete2578, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onUpdateComplete2579;
		protected virtual void onUpdateComplete(int arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._onUpdateComplete2579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._onUpdateComplete2579, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _onDeleteComplete2580;
		protected virtual void onDeleteComplete(int arg0, java.lang.Object arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler._onDeleteComplete2580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._onDeleteComplete2580, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _AsyncQueryHandler2581;
		public AsyncQueryHandler(android.content.ContentResolver arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._AsyncQueryHandler2581, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.AsyncQueryHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AsyncQueryHandler"));
			global::android.content.AsyncQueryHandler._handleMessage2570 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V");
			global::android.content.AsyncQueryHandler._createHandler2571 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "createHandler", "(Landroid/os/Looper;)Landroid/os/Handler;");
			global::android.content.AsyncQueryHandler._startQuery2572 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "startQuery", "(ILjava/lang/Object;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)V");
			global::android.content.AsyncQueryHandler._cancelOperation2573 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "cancelOperation", "(I)V");
			global::android.content.AsyncQueryHandler._startInsert2574 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "startInsert", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;)V");
			global::android.content.AsyncQueryHandler._startUpdate2575 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "startUpdate", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)V");
			global::android.content.AsyncQueryHandler._startDelete2576 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "startDelete", "(ILjava/lang/Object;Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)V");
			global::android.content.AsyncQueryHandler._onQueryComplete2577 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "onQueryComplete", "(ILjava/lang/Object;Landroid/database/Cursor;)V");
			global::android.content.AsyncQueryHandler._onInsertComplete2578 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "onInsertComplete", "(ILjava/lang/Object;Landroid/net/Uri;)V");
			global::android.content.AsyncQueryHandler._onUpdateComplete2579 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "onUpdateComplete", "(ILjava/lang/Object;I)V");
			global::android.content.AsyncQueryHandler._onDeleteComplete2580 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "onDeleteComplete", "(ILjava/lang/Object;I)V");
			global::android.content.AsyncQueryHandler._AsyncQueryHandler2581 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "<init>", "(Landroid/content/ContentResolver;)V");
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
