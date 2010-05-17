namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AsyncTask : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static AsyncTask() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.AsyncTask), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.AsyncTask.Status), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf5073; 
			public static android.os.AsyncTask.Status valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.AsyncTask.Status>(@__env, @__env.CallStaticObjectMethodPtr(android.os.AsyncTask.Status.staticClass, _valueOf5073, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values5074; 
			public static android.os.AsyncTask.Status[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.os.AsyncTask.Status.staticClass, _values5074)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FINISHED5075; 
			public static android.os.AsyncTask.Status FINISHED
			{ 
				get 
				{ 
					return default(android.os.AsyncTask.Status); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _PENDING5076; 
			public static android.os.AsyncTask.Status PENDING
			{ 
				get 
				{ 
					return default(android.os.AsyncTask.Status); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _RUNNING5077; 
			public static android.os.AsyncTask.Status RUNNING
			{ 
				get 
				{ 
					return default(android.os.AsyncTask.Status); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.os.AsyncTask.Status.staticClass = @__class; 
				global::android.os.AsyncTask.Status._valueOf5073 = @__env.GetStaticMethodID(global::android.os.AsyncTask.Status.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/os/AsyncTask$Status;"); 
				global::android.os.AsyncTask.Status._values5074 = @__env.GetStaticMethodID(global::android.os.AsyncTask.Status.staticClass, "values", "()[Landroid/os/AsyncTask/Status;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get5078; 
		public virtual java.lang.Object get() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.AsyncTask)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _get5078)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.AsyncTask.staticClass, _get5078)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _get5079; 
		public virtual java.lang.Object get(long arg0, java.util.concurrent.TimeUnit arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.AsyncTask)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _get5079, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.AsyncTask.staticClass, _get5079, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _execute5080; 
		public virtual android.os.AsyncTask execute(java.lang.Object[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.AsyncTask)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.AsyncTask>(@__env, @__env.CallObjectMethodPtr(this, _execute5080, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.AsyncTask>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.AsyncTask.staticClass, _execute5080, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _cancel5081; 
		public virtual bool cancel(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.AsyncTask)) 
				return @__env.CallBooleanMethod(this, _cancel5081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.AsyncTask.staticClass, _cancel5081, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isCancelled5082; 
		public virtual bool isCancelled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.AsyncTask)) 
				return @__env.CallBooleanMethod(this, _isCancelled5082); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.AsyncTask.staticClass, _isCancelled5082); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getStatus5083; 
		public virtual android.os.AsyncTask.Status getStatus() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.AsyncTask)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.AsyncTask.Status>(@__env, @__env.CallObjectMethodPtr(this, _getStatus5083)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.AsyncTask.Status>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.AsyncTask.staticClass, _getStatus5083)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _doInBackground5084; 
		protected abstract java.lang.Object doInBackground(java.lang.Object[] arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _onPreExecute5085; 
		protected virtual void onPreExecute() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.AsyncTask)) 
				@__env.CallVoidMethod(this, _onPreExecute5085); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.AsyncTask.staticClass, _onPreExecute5085); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onPostExecute5086; 
		protected virtual void onPostExecute(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.AsyncTask)) 
				@__env.CallVoidMethod(this, _onPostExecute5086, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.AsyncTask.staticClass, _onPostExecute5086, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onProgressUpdate5087; 
		protected virtual void onProgressUpdate(java.lang.Object[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.AsyncTask)) 
				@__env.CallVoidMethod(this, _onProgressUpdate5087, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.AsyncTask.staticClass, _onProgressUpdate5087, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onCancelled5088; 
		protected virtual void onCancelled() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.AsyncTask)) 
				@__env.CallVoidMethod(this, _onCancelled5088); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.AsyncTask.staticClass, _onCancelled5088); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _publishProgress5089; 
		protected virtual void publishProgress(java.lang.Object[] arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.AsyncTask)) 
				@__env.CallVoidMethod(this, _publishProgress5089, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.AsyncTask.staticClass, _publishProgress5089, global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AsyncTask5090; 
		public AsyncTask()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.AsyncTask.staticClass, _AsyncTask5090, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.AsyncTask.staticClass = @__class; 
			global::android.os.AsyncTask._get5078 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "get", "()Ljava/lang/Object;"); 
			global::android.os.AsyncTask._get5079 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "get", "(JLjava/util/concurrent/TimeUnit;)Ljava/lang/Object;"); 
			global::android.os.AsyncTask._execute5080 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "execute", "([Ljava/lang/Object;)Landroid/os/AsyncTask;"); 
			global::android.os.AsyncTask._cancel5081 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "cancel", "(Z)Z"); 
			global::android.os.AsyncTask._isCancelled5082 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "isCancelled", "()Z"); 
			global::android.os.AsyncTask._getStatus5083 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "getStatus", "()Landroid/os/AsyncTask$Status;"); 
			global::android.os.AsyncTask._doInBackground5084 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "doInBackground", "([Ljava/lang/Object;)Ljava/lang/Object;"); 
			global::android.os.AsyncTask._onPreExecute5085 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "onPreExecute", "()V"); 
			global::android.os.AsyncTask._onPostExecute5086 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "onPostExecute", "(Ljava/lang/Object;)V"); 
			global::android.os.AsyncTask._onProgressUpdate5087 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "onProgressUpdate", "([Ljava/lang/Object;)V"); 
			global::android.os.AsyncTask._onCancelled5088 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "onCancelled", "()V"); 
			global::android.os.AsyncTask._publishProgress5089 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "publishProgress", "([Ljava/lang/Object;)V"); 
			global::android.os.AsyncTask._AsyncTask5090 = @__env.GetMethodID(global::android.os.AsyncTask.staticClass, "<init>", "()V"); 
		} 
	} 
} 
