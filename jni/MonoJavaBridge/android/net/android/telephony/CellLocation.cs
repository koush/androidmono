namespace android.telephony 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class CellLocation : java.lang.Object
	{ 
		internal static global::java.lang.Class staticClass; 
		static CellLocation() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.CellLocation), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected CellLocation(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requestLocationUpdate6437; 
		public static void requestLocationUpdate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.telephony.CellLocation.staticClass, global::android.telephony.CellLocation._requestLocationUpdate6437); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getEmpty6438; 
		public static global::android.telephony.CellLocation getEmpty() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.telephony.CellLocation>(@__env, @__env.CallStaticObjectMethodPtr(android.telephony.CellLocation.staticClass, global::android.telephony.CellLocation._getEmpty6438)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CellLocation6439; 
		public CellLocation()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.CellLocation.staticClass, global::android.telephony.CellLocation._CellLocation6439, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.telephony.CellLocation.staticClass = @__class; 
			global::android.telephony.CellLocation._requestLocationUpdate6437 = @__env.GetStaticMethodID(global::android.telephony.CellLocation.staticClass, "requestLocationUpdate", "()V"); 
			global::android.telephony.CellLocation._getEmpty6438 = @__env.GetStaticMethodID(global::android.telephony.CellLocation.staticClass, "getEmpty", "()Landroid/telephony/CellLocation;"); 
			global::android.telephony.CellLocation._CellLocation6439 = @__env.GetMethodID(global::android.telephony.CellLocation.staticClass, "<init>", "()V"); 
		} 
	} 
} 
