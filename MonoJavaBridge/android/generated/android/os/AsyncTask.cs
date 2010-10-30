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
			internal static global::MonoJavaBridge.MethodId _values9494;
			public static global::android.os.AsyncTask.Status[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.AsyncTask.Status>(@__env.CallStaticObjectMethod(android.os.AsyncTask.Status.staticClass, global::android.os.AsyncTask.Status._values9494)) as android.os.AsyncTask.Status[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf9495;
			public static global::android.os.AsyncTask.Status valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.AsyncTask.Status>(@__env.CallStaticObjectMethod(android.os.AsyncTask.Status.staticClass, global::android.os.AsyncTask.Status._valueOf9495, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.AsyncTask.Status;
			}
			internal static global::MonoJavaBridge.FieldId _FINISHED9496;
			public static global::android.os.AsyncTask.Status FINISHED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.AsyncTask.Status>(@__env.GetStaticObjectField(global::android.os.AsyncTask.Status.staticClass, _FINISHED9496)) as android.os.AsyncTask.Status;
				}
			}
			internal static global::MonoJavaBridge.FieldId _PENDING9497;
			public static global::android.os.AsyncTask.Status PENDING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.AsyncTask.Status>(@__env.GetStaticObjectField(global::android.os.AsyncTask.Status.staticClass, _PENDING9497)) as android.os.AsyncTask.Status;
				}
			}
			internal static global::MonoJavaBridge.FieldId _RUNNING9498;
			public static global::android.os.AsyncTask.Status RUNNING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.AsyncTask.Status>(@__env.GetStaticObjectField(global::android.os.AsyncTask.Status.staticClass, _RUNNING9498)) as android.os.AsyncTask.Status;
				}
			}
			static Status()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.AsyncTask.Status.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/AsyncTask$Status"));
				global::android.os.AsyncTask.Status._values9494 = @__env.GetStaticMethodIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "values", "()[Landroid/os/AsyncTask/Status;");
				global::android.os.AsyncTask.Status._valueOf9495 = @__env.GetStaticMethodIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/os/AsyncTask$Status;");
				global::android.os.AsyncTask.Status._FINISHED9496 = @__env.GetStaticFieldIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "FINISHED", "Landroid/os/AsyncTask$Status;");
				global::android.os.AsyncTask.Status._PENDING9497 = @__env.GetStaticFieldIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "PENDING", "Landroid/os/AsyncTask$Status;");
				global::android.os.AsyncTask.Status._RUNNING9498 = @__env.GetStaticFieldIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "RUNNING", "Landroid/os/AsyncTask$Status;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _get9499;
		public virtual global::java.lang.Object get()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._get9499)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get9500;
		public virtual global::java.lang.Object get(long arg0, java.util.concurrent.TimeUnit arg1)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._get9500, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute9501;
		public virtual global::android.os.AsyncTask execute(java.lang.Object[] arg0)
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._execute9501, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.AsyncTask;
		}
		internal static global::MonoJavaBridge.MethodId _cancel9502;
		public virtual bool cancel(bool arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._cancel9502, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCancelled9503;
		public virtual bool isCancelled()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._isCancelled9503);
		}
		internal static global::MonoJavaBridge.MethodId _getStatus9504;
		public virtual global::android.os.AsyncTask.Status getStatus()
		{
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.os.AsyncTask.Status>(global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._getStatus9504)) as android.os.AsyncTask.Status;
		}
		internal static global::MonoJavaBridge.MethodId _doInBackground9505;
		protected abstract global::java.lang.Object doInBackground(java.lang.Object[] arg0);
		internal static global::MonoJavaBridge.MethodId _onPreExecute9506;
		protected virtual void onPreExecute()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onPreExecute9506);
		}
		internal static global::MonoJavaBridge.MethodId _onPostExecute9507;
		protected virtual void onPostExecute(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onPostExecute9507, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onProgressUpdate9508;
		protected virtual void onProgressUpdate(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onProgressUpdate9508, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCancelled9509;
		protected virtual void onCancelled()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onCancelled9509);
		}
		internal static global::MonoJavaBridge.MethodId _publishProgress9510;
		protected virtual void publishProgress(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._publishProgress9510, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AsyncTask9511;
		public AsyncTask() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.AsyncTask.staticClass, global::android.os.AsyncTask._AsyncTask9511);
			Init(@__env, handle);
		}
		static AsyncTask()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.AsyncTask.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/AsyncTask"));
			global::android.os.AsyncTask._get9499 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "get", "()Ljava/lang/Object;");
			global::android.os.AsyncTask._get9500 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::android.os.AsyncTask._execute9501 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;");
			global::android.os.AsyncTask._cancel9502 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "cancel", "(Z)Z");
			global::android.os.AsyncTask._isCancelled9503 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "isCancelled", "()Z");
			global::android.os.AsyncTask._getStatus9504 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "getStatus", "()Landroid/os/AsyncTask$Status;");
			global::android.os.AsyncTask._doInBackground9505 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
			global::android.os.AsyncTask._onPreExecute9506 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "onPreExecute", "()V");
			global::android.os.AsyncTask._onPostExecute9507 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "onPostExecute", "(Ljava/lang/Object;)V");
			global::android.os.AsyncTask._onProgressUpdate9508 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "onProgressUpdate", "([Ljava/lang/Object;)V");
			global::android.os.AsyncTask._onCancelled9509 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "onCancelled", "()V");
			global::android.os.AsyncTask._publishProgress9510 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "publishProgress", "([Ljava/lang/Object;)V");
			global::android.os.AsyncTask._AsyncTask9511 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "<init>", "()V");
		}
		internal static void InitJNI()
		{
		}
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::android.os.AsyncTask))]
	internal sealed partial class AsyncTask_ : android.os.AsyncTask
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal AsyncTask_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _doInBackground9512;
		protected override global::java.lang.Object doInBackground(java.lang.Object[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.AsyncTask_._doInBackground9512, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		static AsyncTask_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.AsyncTask_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/AsyncTask"));
			global::android.os.AsyncTask_._doInBackground9512 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask_.staticClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
		}
		internal static void InitJNI()
		{
		}
	}
}
