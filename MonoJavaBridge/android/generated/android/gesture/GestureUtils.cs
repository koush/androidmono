namespace android.gesture
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class GestureUtils : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal GestureUtils(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public static global::android.gesture.OrientedBoundingBox computeOrientedBoundingBox(java.util.ArrayList arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureUtils._m0.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureUtils._m0 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureUtils.staticClass, "computeOrientedBoundingBox", "(Ljava/util/ArrayList;)Landroid/gesture/OrientedBoundingBox;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureUtils.staticClass, global::android.gesture.GestureUtils._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.gesture.OrientedBoundingBox;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public static global::android.gesture.OrientedBoundingBox computeOrientedBoundingBox(float[] arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureUtils._m1.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureUtils._m1 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureUtils.staticClass, "computeOrientedBoundingBox", "([F)Landroid/gesture/OrientedBoundingBox;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.gesture.GestureUtils.staticClass, global::android.gesture.GestureUtils._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.gesture.OrientedBoundingBox;
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public static float[] spatialSampling(android.gesture.Gesture arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureUtils._m2.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureUtils._m2 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureUtils.staticClass, "spatialSampling", "(Landroid/gesture/Gesture;I)[F");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(android.gesture.GestureUtils.staticClass, global::android.gesture.GestureUtils._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as float[];
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public static float[] spatialSampling(android.gesture.Gesture arg0, int arg1, bool arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureUtils._m3.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureUtils._m3 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureUtils.staticClass, "spatialSampling", "(Landroid/gesture/Gesture;IZ)[F");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(android.gesture.GestureUtils.staticClass, global::android.gesture.GestureUtils._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as float[];
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public static float[] temporalSampling(android.gesture.GestureStroke arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.gesture.GestureUtils._m4.native == global::System.IntPtr.Zero)
				global::android.gesture.GestureUtils._m4 = @__env.GetStaticMethodIDNoThrow(global::android.gesture.GestureUtils.staticClass, "temporalSampling", "(Landroid/gesture/GestureStroke;I)[F");
			return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<float>(@__env.CallStaticObjectMethod(android.gesture.GestureUtils.staticClass, global::android.gesture.GestureUtils._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as float[];
		}
		static GestureUtils()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.gesture.GestureUtils.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/gesture/GestureUtils"));
		}
		internal static void InitJNI()
		{
		}
	}
}
