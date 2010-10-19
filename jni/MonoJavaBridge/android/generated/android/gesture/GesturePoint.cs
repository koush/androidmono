namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GesturePoint : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static GesturePoint()
		{
			InitJNI();
		}
		protected GesturePoint(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone3028;
		public virtual global::java.lang.Object clone() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.gesture.GesturePoint._clone3028)) as java.lang.Object;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.gesture.GesturePoint.staticClass, global::android.gesture.GesturePoint._clone3028)) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _GesturePoint3029;
		public GesturePoint(float arg0, float arg1, long arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GesturePoint.staticClass, global::android.gesture.GesturePoint._GesturePoint3029, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _x3030;
		public float x
		{
			get
			{
				return default(float);
			}
		}
		internal static global::MonoJavaBridge.FieldId _y3031;
		public float y
		{
			get
			{
				return default(float);
			}
		}
		internal static global::MonoJavaBridge.FieldId _timestamp3032;
		public long timestamp
		{
			get
			{
				return default(long);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GesturePoint.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GesturePoint"));
			global::android.gesture.GesturePoint._clone3028 = @__env.GetMethodIDNoThrow(global::android.gesture.GesturePoint.staticClass, "clone", "()Ljava/lang/Object;");
			global::android.gesture.GesturePoint._GesturePoint3029 = @__env.GetMethodIDNoThrow(global::android.gesture.GesturePoint.staticClass, "<init>", "(FFJ)V");
		}
	}
}
