namespace android.os
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.os.AsyncTask_))]
	public abstract partial class AsyncTask : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AsyncTask()
		{
			InitJNI();
		}
		protected AsyncTask(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Status : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Status()
			{
				InitJNI();
			}
			internal Status(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values9452;
			public static global::android.os.AsyncTask.Status[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.AsyncTask.Status>(@__env.CallStaticObjectMethod(android.os.AsyncTask.Status.staticClass, global::android.os.AsyncTask.Status._values9452)) as android.os.AsyncTask.Status[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf9453;
			public static global::android.os.AsyncTask.Status valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.AsyncTask.Status>(@__env.CallStaticObjectMethod(android.os.AsyncTask.Status.staticClass, global::android.os.AsyncTask.Status._valueOf9453, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.AsyncTask.Status;
			}
			internal static global::MonoJavaBridge.FieldId _FINISHED9454;
			public static global::android.os.AsyncTask.Status FINISHED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.AsyncTask.Status>(@__env.GetStaticObjectField(global::android.os.AsyncTask.Status.staticClass, _FINISHED9454)) as android.os.AsyncTask.Status;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PENDING9455;
			public static global::android.os.AsyncTask.Status PENDING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.AsyncTask.Status>(@__env.GetStaticObjectField(global::android.os.AsyncTask.Status.staticClass, _PENDING9455)) as android.os.AsyncTask.Status;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RUNNING9456;
			public static global::android.os.AsyncTask.Status RUNNING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.AsyncTask.Status>(@__env.GetStaticObjectField(global::android.os.AsyncTask.Status.staticClass, _RUNNING9456)) as android.os.AsyncTask.Status;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.AsyncTask.Status.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/AsyncTask$Status"));
				global::android.os.AsyncTask.Status._values9452 = @__env.GetStaticMethodIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "values", "()[Landroid/os/AsyncTask/Status;");
				global::android.os.AsyncTask.Status._valueOf9453 = @__env.GetStaticMethodIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/os/AsyncTask$Status;");
				global::android.os.AsyncTask.Status._FINISHED9454 = @__env.GetStaticFieldIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "FINISHED", "Landroid/os/AsyncTask$Status;");
				global::android.os.AsyncTask.Status._PENDING9455 = @__env.GetStaticFieldIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "PENDING", "Landroid/os/AsyncTask$Status;");
				global::android.os.AsyncTask.Status._RUNNING9456 = @__env.GetStaticFieldIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "RUNNING", "Landroid/os/AsyncTask$Status;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _get9457;
		public virtual global::java.lang.Object get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.AsyncTask._get9457)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._get9457)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get9458;
		public virtual global::java.lang.Object get(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.AsyncTask._get9458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._get9458, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute9459;
		public virtual global::android.os.AsyncTask execute(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.AsyncTask._execute9459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.AsyncTask;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._execute9459, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.AsyncTask;
		}
		internal static global::MonoJavaBridge.MethodId _cancel9460;
		public virtual bool cancel(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.AsyncTask._cancel9460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._cancel9460, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCancelled9461;
		public virtual bool isCancelled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.AsyncTask._isCancelled9461);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._isCancelled9461);
		}
		internal static global::MonoJavaBridge.MethodId _getStatus9462;
		public virtual global::android.os.AsyncTask.Status getStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.AsyncTask.Status>(@__env.CallObjectMethod(this.JvmHandle, global::android.os.AsyncTask._getStatus9462)) as android.os.AsyncTask.Status;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.AsyncTask.Status>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._getStatus9462)) as android.os.AsyncTask.Status;
		}
		internal static global::MonoJavaBridge.MethodId _doInBackground9463;
		protected abstract global::java.lang.Object doInBackground(java.lang.Object[] arg0);
		internal static global::MonoJavaBridge.MethodId _onPreExecute9464;
		protected virtual void onPreExecute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.AsyncTask._onPreExecute9464);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onPreExecute9464);
		}
		internal static global::MonoJavaBridge.MethodId _onPostExecute9465;
		protected virtual void onPostExecute(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.AsyncTask._onPostExecute9465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onPostExecute9465, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onProgressUpdate9466;
		protected virtual void onProgressUpdate(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.AsyncTask._onProgressUpdate9466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onProgressUpdate9466, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCancelled9467;
		protected virtual void onCancelled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.AsyncTask._onCancelled9467);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onCancelled9467);
		}
		internal static global::MonoJavaBridge.MethodId _publishProgress9468;
		protected virtual void publishProgress(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.AsyncTask._publishProgress9468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._publishProgress9468, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AsyncTask9469;
		public AsyncTask()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.AsyncTask.staticClass, global::android.os.AsyncTask._AsyncTask9469);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.AsyncTask.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/AsyncTask"));
			global::android.os.AsyncTask._get9457 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "get", "()Ljava/lang/Object;");
			global::android.os.AsyncTask._get9458 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::android.os.AsyncTask._execute9459 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;");
			global::android.os.AsyncTask._cancel9460 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "cancel", "(Z)Z");
			global::android.os.AsyncTask._isCancelled9461 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "isCancelled", "()Z");
			global::android.os.AsyncTask._getStatus9462 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "getStatus", "()Landroid/os/AsyncTask$Status;");
			global::android.os.AsyncTask._doInBackground9463 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
			global::android.os.AsyncTask._onPreExecute9464 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "onPreExecute", "()V");
			global::android.os.AsyncTask._onPostExecute9465 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "onPostExecute", "(Ljava/lang/Object;)V");
			global::android.os.AsyncTask._onProgressUpdate9466 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "onProgressUpdate", "([Ljava/lang/Object;)V");
			global::android.os.AsyncTask._onCancelled9467 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "onCancelled", "()V");
			global::android.os.AsyncTask._publishProgress9468 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "publishProgress", "([Ljava/lang/Object;)V");
			global::android.os.AsyncTask._AsyncTask9469 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "<init>", "()V");
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.AsyncTask))]
	public sealed partial class AsyncTask_ : android.os.AsyncTask
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static AsyncTask_()
		{
			InitJNI();
		}
		internal AsyncTask_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _doInBackground9470;
		protected override global::java.lang.Object doInBackground(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.AsyncTask_._doInBackground9470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.AsyncTask_.staticClass, global::android.os.AsyncTask_._doInBackground9470, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.AsyncTask_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/AsyncTask"));
			global::android.os.AsyncTask_._doInBackground9470 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask_.staticClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
		}
	}
}
