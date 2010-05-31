namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Parcelable 
	{ 
		void writeToParcel(android.os.Parcel arg0, int arg1); 
		int describeContents(); 
	} 

	public partial class Parcelable_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __Parcelable.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __Parcelable : java.lang.Object, Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static __Parcelable() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.__Parcelable), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.__Parcelable(@__env); 
			} 
		} 
		internal __Parcelable(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel5817; 
		 void android.os.Parcelable.writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.os.__Parcelable._writeToParcel5817, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.os.__Parcelable.staticClass, global::android.os.__Parcelable._writeToParcel5817, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents5818; 
		 int android.os.Parcelable.describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.os.__Parcelable._describeContents5818); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.os.__Parcelable.staticClass, global::android.os.__Parcelable._describeContents5818); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.__Parcelable.staticClass = @__class; 
			global::android.os.__Parcelable._writeToParcel5817 = @__env.GetMethodID(global::android.os.__Parcelable.staticClass, "android.os.Parcelable.writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.os.__Parcelable._describeContents5818 = @__env.GetMethodID(global::android.os.__Parcelable.staticClass, "android.os.Parcelable.describeContents", "()I"); 
		} 
	} 
} 
