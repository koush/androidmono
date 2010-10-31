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
			internal static global::MonoJavaBridge.FieldId _uri1607;
			public global::android.net.Uri uri
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _uri1607)) as android.net.Uri;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _handler1608;
			public global::android.os.Handler handler
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _handler1608)) as android.os.Handler;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _projection1609;
			public global::java.lang.String[] projection
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _projection1609)) as java.lang.String[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _selection1610;
			public global::java.lang.String selection
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _selection1610)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _selectionArgs1611;
			public global::java.lang.String[] selectionArgs
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _selectionArgs1611)) as java.lang.String[];
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _orderBy1612;
			public global::java.lang.String orderBy
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.GetObjectField(this.JvmHandle, _orderBy1612)) as java.lang.String;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _result1613;
			public global::java.lang.Object result
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _result1613)) as java.lang.Object;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _cookie1614;
			public global::java.lang.Object cookie
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.GetObjectField(this.JvmHandle, _cookie1614)) as java.lang.Object;
				}
				set
				{
				}
			}
			internal static global::MonoJavaBridge.FieldId _values1615;
			public global::android.content.ContentValues values
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.content.ContentValues>(@__env.GetObjectField(this.JvmHandle, _values1615)) as android.content.ContentValues;
				}
				set
				{
				}
			}
			static WorkerArgs()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.AsyncQueryHandler.WorkerArgs.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AsyncQueryHandler$WorkerArgs"));
				global::android.content.AsyncQueryHandler.WorkerArgs._uri1607 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "uri", "Landroid/net/Uri;");
				global::android.content.AsyncQueryHandler.WorkerArgs._handler1608 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "handler", "Landroid/os/Handler;");
				global::android.content.AsyncQueryHandler.WorkerArgs._projection1609 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "projection", "[Ljava/lang/String;");
				global::android.content.AsyncQueryHandler.WorkerArgs._selection1610 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "selection", "Ljava/lang/String;");
				global::android.content.AsyncQueryHandler.WorkerArgs._selectionArgs1611 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "selectionArgs", "[Ljava/lang/String;");
				global::android.content.AsyncQueryHandler.WorkerArgs._orderBy1612 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "orderBy", "Ljava/lang/String;");
				global::android.content.AsyncQueryHandler.WorkerArgs._result1613 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "result", "Ljava/lang/Object;");
				global::android.content.AsyncQueryHandler.WorkerArgs._cookie1614 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "cookie", "Ljava/lang/Object;");
				global::android.content.AsyncQueryHandler.WorkerArgs._values1615 = @__env.GetFieldIDNoThrow(global::android.content.AsyncQueryHandler.WorkerArgs.staticClass, "values", "Landroid/content/ContentValues;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		protected partial class WorkerHandler : android.os.Handler
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected WorkerHandler(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public override void handleMessage(android.os.Message arg0)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.WorkerHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V", ref global::android.content.AsyncQueryHandler.WorkerHandler._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public WorkerHandler(android.content.AsyncQueryHandler arg0, android.os.Looper arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.content.AsyncQueryHandler.WorkerHandler._m1.native == global::System.IntPtr.Zero)
					global::android.content.AsyncQueryHandler.WorkerHandler._m1 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.WorkerHandler.staticClass, "<init>", "(Landroid/content/AsyncQueryHandler;Landroid/os/Looper;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.AsyncQueryHandler.WorkerHandler.staticClass, global::android.content.AsyncQueryHandler.WorkerHandler._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			static WorkerHandler()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.content.AsyncQueryHandler.WorkerHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AsyncQueryHandler$WorkerHandler"));
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override void handleMessage(android.os.Message arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "handleMessage", "(Landroid/os/Message;)V", ref global::android.content.AsyncQueryHandler._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		protected virtual global::android.os.Handler createHandler(android.os.Looper arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.content.AsyncQueryHandler.staticClass, "createHandler", "(Landroid/os/Looper;)Landroid/os/Handler;", ref global::android.content.AsyncQueryHandler._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.Handler;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void startQuery(int arg0, java.lang.Object arg1, android.net.Uri arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String[] arg5, java.lang.String arg6)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "startQuery", "(ILjava/lang/Object;Landroid/net/Uri;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)V", ref global::android.content.AsyncQueryHandler._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void cancelOperation(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "cancelOperation", "(I)V", ref global::android.content.AsyncQueryHandler._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual void startInsert(int arg0, java.lang.Object arg1, android.net.Uri arg2, android.content.ContentValues arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "startInsert", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;)V", ref global::android.content.AsyncQueryHandler._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void startUpdate(int arg0, java.lang.Object arg1, android.net.Uri arg2, android.content.ContentValues arg3, java.lang.String arg4, java.lang.String[] arg5)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "startUpdate", "(ILjava/lang/Object;Landroid/net/Uri;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)V", ref global::android.content.AsyncQueryHandler._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual void startDelete(int arg0, java.lang.Object arg1, android.net.Uri arg2, java.lang.String arg3, java.lang.String[] arg4)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "startDelete", "(ILjava/lang/Object;Landroid/net/Uri;Ljava/lang/String;[Ljava/lang/String;)V", ref global::android.content.AsyncQueryHandler._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual void onQueryComplete(int arg0, java.lang.Object arg1, android.database.Cursor arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "onQueryComplete", "(ILjava/lang/Object;Landroid/database/Cursor;)V", ref global::android.content.AsyncQueryHandler._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual void onInsertComplete(int arg0, java.lang.Object arg1, android.net.Uri arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "onInsertComplete", "(ILjava/lang/Object;Landroid/net/Uri;)V", ref global::android.content.AsyncQueryHandler._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual void onUpdateComplete(int arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "onUpdateComplete", "(ILjava/lang/Object;I)V", ref global::android.content.AsyncQueryHandler._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual void onDeleteComplete(int arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.content.AsyncQueryHandler.staticClass, "onDeleteComplete", "(ILjava/lang/Object;I)V", ref global::android.content.AsyncQueryHandler._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public AsyncQueryHandler(android.content.ContentResolver arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.content.AsyncQueryHandler._m11.native == global::System.IntPtr.Zero)
				global::android.content.AsyncQueryHandler._m11 = @__env.GetMethodIDNoThrow(global::android.content.AsyncQueryHandler.staticClass, "<init>", "(Landroid/content/ContentResolver;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.AsyncQueryHandler.staticClass, global::android.content.AsyncQueryHandler._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		static AsyncQueryHandler()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.AsyncQueryHandler.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/AsyncQueryHandler"));
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
	}
}
