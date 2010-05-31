namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AsyncTask : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AsyncTask() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.AsyncTask), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AsyncTask(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Status : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static Status() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.AsyncTask.Status), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.os.AsyncTask.Status(@__env); 
				} 
			} 
			internal Status(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf5331; 
			public static global::android.os.AsyncTask.Status valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.AsyncTask.Status>(@__env, @__env.CallStaticObjectMethodPtr(android.os.AsyncTask.Status.staticClass, global::android.os.AsyncTask.Status._valueOf5331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values5332; 
			public static global::android.os.AsyncTask.Status[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.os.AsyncTask.Status.staticClass, global::android.os.AsyncTask.Status._values5332)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FINISHED5333; 
			public static global::android.os.AsyncTask.Status FINISHED
			{ 
				get 
				{ 
					return default(global::android.os.AsyncTask.Status); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _PENDING5334; 
			public static global::android.os.AsyncTask.Status PENDING
			{ 
				get 
				{ 
					return default(global::android.os.AsyncTask.Status); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _RUNNING5335; 
			public static global::android.os.AsyncTask.Status RUNNING
			{ 
				get 
				{ 
					return default(global::android.os.AsyncTask.Status); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.os.AsyncTask.Status.staticClass = @__class; 
				global::android.os.AsyncTask.Status._valueOf5331 = @__env.GetStaticMethodID(global::android.os.AsyncTask.Status.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/os/AsyncTask$Status;"); 
				global::android.os.AsyncTask.Status._values5332 = @__env.GetStaticMethodID(global::android.os.AsyncTask.Status.staticClass, "values", "()[Landroid/os/AsyncTask/Status;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get5336; 
		public virtual global::java.lang.Object get() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.AsyncTask._get5336)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._get5336)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get5337; 
		public virtual global::java.lang.Object get(long arg0, java.util.concurrent.TimeUnit arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.AsyncTask._get5337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._get5337, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _execute5338; 
		public virtual global::android.os.AsyncTask execute(java.lang.Object[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.AsyncTask>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.AsyncTask._execute5338, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.AsyncTask>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._execute5338, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel5339; 
		public virtual bool cancel(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.os.AsyncTask._cancel5339, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._cancel5339, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isCancelled5340; 
		public virtual bool isCancelled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.os.AsyncTask._isCancelled5340); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._isCancelled5340); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStatus5341; 
		public virtual global::android.os.AsyncTask.Status getStatus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.AsyncTask.Status>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.AsyncTask._getStatus5341)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.AsyncTask.Status>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._getStatus5341)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _doInBackground5342; 
		protected abstract global::java.lang.Object doInBackground(java.lang.Object[] arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _onPreExecute5343; 
		protected virtual void onPreExecute() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.os.AsyncTask._onPreExecute5343); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onPreExecute5343); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPostExecute5344; 
		protected virtual void onPostExecute(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.os.AsyncTask._onPostExecute5344, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onPostExecute5344, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onProgressUpdate5345; 
		protected virtual void onProgressUpdate(java.lang.Object[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.os.AsyncTask._onProgressUpdate5345, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onProgressUpdate5345, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCancelled5346; 
		protected virtual void onCancelled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.os.AsyncTask._onCancelled5346); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._onCancelled5346); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _publishProgress5347; 
		protected virtual void publishProgress(java.lang.Object[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.os.AsyncTask._publishProgress5347, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.AsyncTask.staticClass, global::android.os.AsyncTask._publishProgress5347, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AsyncTask5348; 
		public AsyncTask()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.AsyncTask.staticClass, global::android.os.AsyncTask._AsyncTask5348, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.AsyncTask.staticClass = @__class; 
			global::android.os.AsyncTask._get5336 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "get", "()Ljava/lang/Object;"); 
			global::android.os.AsyncTask._get5337 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;"); 
			global::android.os.AsyncTask._execute5338 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;"); 
			global::android.os.AsyncTask._cancel5339 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "cancel", "(Z)Z"); 
			global::android.os.AsyncTask._isCancelled5340 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "isCancelled", "()Z"); 
			global::android.os.AsyncTask._getStatus5341 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "getStatus", "()Landroid/os/AsyncTask$Status;"); 
			global::android.os.AsyncTask._doInBackground5342 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::android.os.AsyncTask._onPreExecute5343 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "onPreExecute", "()V"); 
			global::android.os.AsyncTask._onPostExecute5344 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "onPostExecute", "(Ljava/lang/Object;)V"); 
			global::android.os.AsyncTask._onProgressUpdate5345 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "onProgressUpdate", "([Ljava/lang/Object;)V"); 
			global::android.os.AsyncTask._onCancelled5346 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "onCancelled", "()V"); 
			global::android.os.AsyncTask._publishProgress5347 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "publishProgress", "([Ljava/lang/Object;)V"); 
			global::android.os.AsyncTask._AsyncTask5348 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "<init>", "()V"); 
		} 
	} 
} 
