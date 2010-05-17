namespace android.gesture 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Prediction : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static Prediction() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.gesture.Prediction), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.gesture.Prediction(@__env); 
			} 
		} 
		protected Prediction(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString2498; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.gesture.Prediction)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString2498)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.gesture.Prediction.staticClass, _toString2498)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _name2499; 
		public java.lang.String name
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _score2500; 
		public double score
		{ 
			get 
			{ 
				return default(double); 
			} 
			set 
			{ 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.gesture.Prediction.staticClass = @__class; 
			global::android.gesture.Prediction._toString2498 = @__env.GetMethodID(global::android.gesture.Prediction.staticClass, "toString", "()Ljava/lang/String;"); 
		} 
	} 
} 
