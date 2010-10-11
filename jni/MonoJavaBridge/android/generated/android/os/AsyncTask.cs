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
			internal static global::MonoJavaBridge.MethodId _values6125;
			public static global::android.os.AsyncTask.Status[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.os.AsyncTask.Status>(@__env.CallStaticObjectMethod(android.os.AsyncTask.Status.staticClass, global::android.os.AsyncTask.Status._values6125)) as android.os.AsyncTask.Status[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf6126;
			public static global::android.os.AsyncTask.Status valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.os.AsyncTask.Status.staticClass, global::android.os.AsyncTask.Status._valueOf6126, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.AsyncTask.Status;
			}
			internal static global::MonoJavaBridge.FieldId _FINISHED6127;
			public static global::android.os.AsyncTask.Status FINISHED
			{
				get
				{
					return default(global::android.os.AsyncTask.Status);
				}
			}
			internal static global::MonoJavaBridge.FieldId _PENDING6128;
			public static global::android.os.AsyncTask.Status PENDING
			{
				get
				{
					return default(global::android.os.AsyncTask.Status);
				}
			}
			internal static global::MonoJavaBridge.FieldId _RUNNING6129;
			public static global::android.os.AsyncTask.Status RUNNING
			{
				get
				{
					return default(global::android.os.AsyncTask.Status);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.AsyncTask.Status.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/AsyncTask$Status"));
				global::android.os.AsyncTask.Status._values6125 = @__env.GetStaticMethodIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "values", "()[Landroid/os/AsyncTask/Status;");
				global::android.os.AsyncTask.Status._valueOf6126 = @__env.GetStaticMethodIDNoThrow(global::android.os.AsyncTask.Status.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/os/AsyncTask$Status;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _get6130;
		public virtual global::java.lang.Object get() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.AsyncTask._get6130)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._get6130)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _get6131;
		public virtual global::java.lang.Object get(long arg0, java.util.concurrent.TimeUnit arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.AsyncTask._get6131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._get6131, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _execute6132;
		public virtual global::android.os.AsyncTask execute(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.AsyncTask._execute6132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.AsyncTask;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._execute6132, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.os.AsyncTask;
		}
		internal static global::MonoJavaBridge.MethodId _cancel6133;
		public virtual bool cancel(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.AsyncTask._cancel6133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._cancel6133, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _isCancelled6134;
		public virtual bool isCancelled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.AsyncTask._isCancelled6134);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._isCancelled6134);
		}
		internal static global::MonoJavaBridge.MethodId _getStatus6135;
		public virtual global::android.os.AsyncTask.Status getStatus() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.AsyncTask._getStatus6135)) as android.os.AsyncTask.Status;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._getStatus6135)) as android.os.AsyncTask.Status;
		}
		internal static global::MonoJavaBridge.MethodId _doInBackground6136;
		protected abstract global::java.lang.Object doInBackground(java.lang.Object[] arg0);
		internal static global::MonoJavaBridge.MethodId _onPreExecute6137;
		protected virtual void onPreExecute() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.AsyncTask._onPreExecute6137);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onPreExecute6137);
		}
		internal static global::MonoJavaBridge.MethodId _onPostExecute6138;
		protected virtual void onPostExecute(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.AsyncTask._onPostExecute6138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onPostExecute6138, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onProgressUpdate6139;
		protected virtual void onProgressUpdate(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.AsyncTask._onProgressUpdate6139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onProgressUpdate6139, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _onCancelled6140;
		protected virtual void onCancelled() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.AsyncTask._onCancelled6140);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onCancelled6140);
		}
		internal static global::MonoJavaBridge.MethodId _publishProgress6141;
		protected virtual void publishProgress(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.AsyncTask._publishProgress6141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._publishProgress6141, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _AsyncTask6142;
		public AsyncTask()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.AsyncTask.staticClass, global::android.os.AsyncTask._AsyncTask6142);
			Init(@__env, handle);
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.AsyncTask.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/AsyncTask"));
			global::android.os.AsyncTask._get6130 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "get", "()Ljava/lang/Object;");
			global::android.os.AsyncTask._get6131 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;");
			global::android.os.AsyncTask._execute6132 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;");
			global::android.os.AsyncTask._cancel6133 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "cancel", "(Z)Z");
			global::android.os.AsyncTask._isCancelled6134 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "isCancelled", "()Z");
			global::android.os.AsyncTask._getStatus6135 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "getStatus", "()Landroid/os/AsyncTask$Status;");
			global::android.os.AsyncTask._doInBackground6136 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
			global::android.os.AsyncTask._onPreExecute6137 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "onPreExecute", "()V");
			global::android.os.AsyncTask._onPostExecute6138 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "onPostExecute", "(Ljava/lang/Object;)V");
			global::android.os.AsyncTask._onProgressUpdate6139 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "onProgressUpdate", "([Ljava/lang/Object;)V");
			global::android.os.AsyncTask._onCancelled6140 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "onCancelled", "()V");
			global::android.os.AsyncTask._publishProgress6141 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "publishProgress", "([Ljava/lang/Object;)V");
			global::android.os.AsyncTask._AsyncTask6142 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask.staticClass, "<init>", "()V");
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
		internal static global::MonoJavaBridge.MethodId _doInBackground6143;
		protected override global::java.lang.Object doInBackground(java.lang.Object[] arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.AsyncTask_._doInBackground6143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.AsyncTask_.staticClass, global::android.os.AsyncTask_._doInBackground6143, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.Object;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.AsyncTask_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/AsyncTask"));
			global::android.os.AsyncTask_._doInBackground6143 = @__env.GetMethodIDNoThrow(global::android.os.AsyncTask_.staticClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;");
		}
	}
}
