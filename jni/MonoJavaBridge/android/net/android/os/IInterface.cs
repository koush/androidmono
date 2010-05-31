namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface IInterface 
	{ 
		global::android.os.IBinder asBinder(); 
	} 

	public partial class IInterface_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __IInterface.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __IInterface : java.lang.Object, IInterface
	{ 
		internal static global::java.lang.Class staticClass; 
		static __IInterface() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.__IInterface), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.__IInterface(@__env); 
			} 
		} 
		internal __IInterface(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _asBinder5627; 
		 global::android.os.IBinder android.os.IInterface.asBinder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.__IInterface._asBinder5627)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.__IInterface.staticClass, global::android.os.__IInterface._asBinder5627)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.__IInterface.staticClass = @__class; 
			global::android.os.__IInterface._asBinder5627 = @__env.GetMethodID(global::android.os.__IInterface.staticClass, "android.os.IInterface.asBinder", "()Landroid/os/IBinder;"); 
		} 
	} 
} 
