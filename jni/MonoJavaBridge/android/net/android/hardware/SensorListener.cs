namespace android.hardware 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface SensorListener 
	{ 
		void onSensorChanged(int arg0, float[] arg1); 
		void onAccuracyChanged(int arg0, int arg1); 
	} 

	public partial class SensorListener_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __SensorListener.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __SensorListener : java.lang.Object, SensorListener
	{ 
		internal static global::java.lang.Class staticClass; 
		static __SensorListener() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.hardware.__SensorListener), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.hardware.__SensorListener(@__env); 
			} 
		} 
		internal __SensorListener(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onSensorChanged3943; 
		 void android.hardware.SensorListener.onSensorChanged(int arg0, float[] arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.hardware.__SensorListener._onSensorChanged3943, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.__SensorListener.staticClass, global::android.hardware.__SensorListener._onSensorChanged3943, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onAccuracyChanged3944; 
		 void android.hardware.SensorListener.onAccuracyChanged(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.hardware.__SensorListener._onAccuracyChanged3944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.hardware.__SensorListener.staticClass, global::android.hardware.__SensorListener._onAccuracyChanged3944, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.hardware.__SensorListener.staticClass = @__class; 
			global::android.hardware.__SensorListener._onSensorChanged3943 = @__env.GetMethodID(global::android.hardware.__SensorListener.staticClass, "android.hardware.SensorListener.onSensorChanged", "(I[F)V"); 
			global::android.hardware.__SensorListener._onAccuracyChanged3944 = @__env.GetMethodID(global::android.hardware.__SensorListener.staticClass, "android.hardware.SensorListener.onAccuracyChanged", "(II)V"); 
		} 
	} 
} 
