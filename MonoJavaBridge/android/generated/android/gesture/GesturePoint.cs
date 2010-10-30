namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class GesturePoint : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected GesturePoint(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _clone4961;
		public virtual global::java.lang.Object clone()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GesturePoint._clone4961.native == global::System.IntPtr.Zero)
				global::android.gesture.GesturePoint._clone4961 = @__env.GetMethodIDNoThrow(global::android.gesture.GesturePoint.staticClass, "clone", "()Ljava/lang/Object;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.gesture.GesturePoint.staticClass, global::android.gesture.GesturePoint._clone4961) as java.lang.Object;
		}
		internal static global::MonoJavaBridge.MethodId _GesturePoint4962;
		public GesturePoint(float arg0, float arg1, long arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GesturePoint._GesturePoint4962.native == global::System.IntPtr.Zero)
				global::android.gesture.GesturePoint._GesturePoint4962 = @__env.GetMethodIDNoThrow(global::android.gesture.GesturePoint.staticClass, "<init>", "(FFJ)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.gesture.GesturePoint.staticClass, global::android.gesture.GesturePoint._GesturePoint4962, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _x4963;
		public float x
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _x4963);
			}
		}
		internal static global::MonoJavaBridge.FieldId _y4964;
		public float y
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetFloatField(this.JvmHandle, _y4964);
			}
		}
		internal static global::MonoJavaBridge.FieldId _timestamp4965;
		public long timestamp
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return @__env.GetLongField(this.JvmHandle, _timestamp4965);
			}
		}
		static GesturePoint()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GesturePoint.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GesturePoint"));
			global::android.gesture.GesturePoint._x4963 = @__env.GetFieldIDNoThrow(global::android.gesture.GesturePoint.staticClass, "x", "F");
			global::android.gesture.GesturePoint._y4964 = @__env.GetFieldIDNoThrow(global::android.gesture.GesturePoint.staticClass, "y", "F");
			global::android.gesture.GesturePoint._timestamp4965 = @__env.GetFieldIDNoThrow(global::android.gesture.GesturePoint.staticClass, "timestamp", "J");
		}
		internal static void InitJNI()
		{
		}
	}
}
