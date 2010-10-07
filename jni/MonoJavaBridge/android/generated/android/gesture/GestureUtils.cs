namespace android.gesture
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class GestureUtils : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static GestureUtils()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.gesture.GestureUtils), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.gesture.GestureUtils(@__env);
			}
		}
		internal GestureUtils(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeOrientedBoundingBox2884;
		public static global::android.gesture.OrientedBoundingBox computeOrientedBoundingBox(java.util.ArrayList arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.OrientedBoundingBox>(@__env, @__env.CallStaticObjectMethodPtr(android.gesture.GestureUtils.staticClass, global::android.gesture.GestureUtils._computeOrientedBoundingBox2884, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _computeOrientedBoundingBox2885;
		public static global::android.gesture.OrientedBoundingBox computeOrientedBoundingBox(float[] arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.gesture.OrientedBoundingBox>(@__env, @__env.CallStaticObjectMethodPtr(android.gesture.GestureUtils.staticClass, global::android.gesture.GestureUtils._computeOrientedBoundingBox2885, global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _spatialSampling2886;
		public static float[] spatialSampling(android.gesture.Gesture arg0, int arg1) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.gesture.GestureUtils.staticClass, global::android.gesture.GestureUtils._spatialSampling2886, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _spatialSampling2887;
		public static float[] spatialSampling(android.gesture.Gesture arg0, int arg1, bool arg2) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.gesture.GestureUtils.staticClass, global::android.gesture.GestureUtils._spatialSampling2887, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _temporalSampling2888;
		public static float[] temporalSampling(android.gesture.GestureStroke arg0, int arg1) 
		{
			return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.gesture.GestureUtils.staticClass, global::android.gesture.GestureUtils._temporalSampling2888, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.gesture.GestureUtils.staticClass = @__class;
			global::android.gesture.GestureUtils._computeOrientedBoundingBox2884 = @__env.GetStaticMethodID(global::android.gesture.GestureUtils.staticClass, "computeOrientedBoundingBox", "(Ljava/util/ArrayList;)Landroid/gesture/OrientedBoundingBox;");
			global::android.gesture.GestureUtils._computeOrientedBoundingBox2885 = @__env.GetStaticMethodID(global::android.gesture.GestureUtils.staticClass, "computeOrientedBoundingBox", "([F)Landroid/gesture/OrientedBoundingBox;");
			global::android.gesture.GestureUtils._spatialSampling2886 = @__env.GetStaticMethodID(global::android.gesture.GestureUtils.staticClass, "spatialSampling", "(Landroid/gesture/Gesture;I)[F");
			global::android.gesture.GestureUtils._spatialSampling2887 = @__env.GetStaticMethodID(global::android.gesture.GestureUtils.staticClass, "spatialSampling", "(Landroid/gesture/Gesture;IZ)[F");
			global::android.gesture.GestureUtils._temporalSampling2888 = @__env.GetStaticMethodID(global::android.gesture.GestureUtils.staticClass, "temporalSampling", "(Landroid/gesture/GestureStroke;I)[F");
		}
	}
}
