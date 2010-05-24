namespace android.gesture 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class GesturePoint : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static GesturePoint() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.gesture.GesturePoint), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.gesture.GesturePoint(@__env); 
			} 
		} 
		protected GesturePoint(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _GesturePoint2664; 
		public GesturePoint(float arg0, float arg1, long arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.gesture.GesturePoint.staticClass, _GesturePoint2664, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _x2665; 
		public float x
		{ 
			get 
			{ 
				return default(float); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _y2666; 
		public float y
		{ 
			get 
			{ 
				return default(float); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _timestamp2667; 
		public long timestamp
		{ 
			get 
			{ 
				return default(long); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.gesture.GesturePoint.staticClass = @__class; 
			global::android.gesture.GesturePoint._GesturePoint2664 = @__env.GetMethodID(global::android.gesture.GesturePoint.staticClass, "<init>", "(FFJ)V"); 
		} 
	} 
} 
