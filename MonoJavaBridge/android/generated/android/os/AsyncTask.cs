namespace android.os
{
	[global::MonoJavaBridge.JavaClass(typeof(global::android.os.AsyncTask_))]
	public abstract partial class AsyncTask : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected AsyncTask(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Status : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal Status(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.os.AsyncTask.Status[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.AsyncTask.Status._m0.native == global::System.IntPtr.Zero)
					global::android.os.AsyncTask.Status._m0 = @__env.GetStaticMethodIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "values", "()[Landroid/os/AsyncTask/Status;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.AsyncTask.Status>(@__env.CallStaticObjectMethod(android.os.AsyncTask.Status.staticClass, global::android.os.AsyncTask.Status._m0)) as android.os.AsyncTask.Status[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.os.AsyncTask.Status valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.AsyncTask.Status._m1.native == global::System.IntPtr.Zero)
					global::android.os.AsyncTask.Status._m1 = @__env.GetStaticMethodIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/os/AsyncTask$Status;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.AsyncTask.Status>(@__env.CallStaticObjectMethod(android.os.AsyncTask.Status.staticClass, global::android.os.AsyncTask.Status._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.AsyncTask.Status;
			}
			internal static global::MonoJavaBridge.FieldId _FINISHED3886;
			public static global::android.os.AsyncTask.Status FINISHED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.AsyncTask.Status>(@__env.GetStaticObjectField(global::android.os.AsyncTask.Status.staticClass, _FINISHED3886)) as android.os.AsyncTask.Status;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PENDING3887;
			public static global::android.os.AsyncTask.Status PENDING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.AsyncTask.Status>(@__env.GetStaticObjectField(global::android.os.AsyncTask.Status.staticClass, _PENDING3887)) as android.os.AsyncTask.Status;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RUNNING3888;
			public static global::android.os.AsyncTask.Status RUNNING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.AsyncTask.Status>(@__env.GetStaticObjectField(global::android.os.AsyncTask.Status.staticClass, _RUNNING3888)) as android.os.AsyncTask.Status;
				}
			}
			static Status()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.AsyncTask.Status.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/AsyncTask$Status"));
				global::android.os.AsyncTask.Status._FINISHED3886 = @__env.GetStaticFieldIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "FINISHED", "Landroid/os/AsyncTask$Status;");
				global::android.os.AsyncTask.Status._PENDING3887 = @__env.GetStaticFieldIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "PENDING", "Landroid/os/AsyncTask$Status;");
				global::android.os.AsyncTask.Status._RUNNING3888 = @__env.GetStaticFieldIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "RUNNING", "Landroid/os/AsyncTask$Status;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::java.lang.Object get()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.AsyncTask.staticClass, "get", "()Ljava/lang/Object;", ref global::android.os.AsyncTask._m0) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::java.lang.Object get(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.AsyncTask.staticClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;", ref global::android.os.AsyncTask._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as java.lang.Object;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual global::android.os.AsyncTask execute(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.AsyncTask.staticClass, "execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;", ref global::android.os.AsyncTask._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.os.AsyncTask;
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual bool cancel(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.AsyncTask.staticClass, "cancel", "(Z)Z", ref global::android.os.AsyncTask._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isCancelled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.AsyncTask.staticClass, "isCancelled", "()Z", ref global::android.os.AsyncTask._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual global::android.os.AsyncTask.Status getStatus()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.os.AsyncTask.Status>(this, global::android.os.AsyncTask.staticClass, "getStatus", "()Landroid/os/AsyncTask$Status;", ref global::android.os.AsyncTask._m5) as android.os.AsyncTask.Status;
		}
		private static global::MonoJavaBridge.MethodId _m6;
		protected abstract global::java.lang.Object doInBackground(java.lang.Object[] arg0);
		private static global::MonoJavaBridge.MethodId _m7;
		protected virtual void onPreExecute()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.AsyncTask.staticClass, "onPreExecute", "()V", ref global::android.os.AsyncTask._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		protected virtual void onPostExecute(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.AsyncTask.staticClass, "onPostExecute", "(Ljava/lang/Object;)V", ref global::android.os.AsyncTask._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		protected virtual void onProgressUpdate(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.AsyncTask.staticClass, "onProgressUpdate", "([Ljava/lang/Object;)V", ref global::android.os.AsyncTask._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		protected virtual void onCancelled()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.AsyncTask.staticClass, "onCancelled", "()V", ref global::android.os.AsyncTask._m10);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		protected virtual void publishProgress(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.AsyncTask.staticClass, "publishProgress", "([Ljava/lang/Object;)V", ref global::android.os.AsyncTask._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public AsyncTask() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.AsyncTask._m12.native == global::System.IntPtr.Zero)
				global::android.os.AsyncTask._m12 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.AsyncTask.staticClass, global::android.os.AsyncTask._m12);
			Init(@__env, handle);
		}
		static AsyncTask()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.AsyncTask.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/AsyncTask"));
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.AsyncTask))]
	internal sealed partial class AsyncTask_ : android.os.AsyncTask
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AsyncTask_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override global::java.lang.Object doInBackground(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.AsyncTask_.staticClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;", ref global::android.os.AsyncTask_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.Object;
		}
		static AsyncTask_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.AsyncTask_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/AsyncTask"));
		}
	}
}
