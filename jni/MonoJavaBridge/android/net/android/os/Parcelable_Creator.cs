namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface Parcelable_Creator 
	{ 
		java.lang.Object[] newArray(int arg0); 
		java.lang.Object createFromParcel(android.os.Parcel arg0); 
	} 

	public partial class Parcelable_Creator_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __Parcelable_Creator.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __Parcelable_Creator : java.lang.Object, Parcelable_Creator
	{ 
		internal static global::java.lang.Class staticClass; 
		static __Parcelable_Creator() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.__Parcelable_Creator), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.__Parcelable_Creator(@__env); 
			} 
		} 
		internal __Parcelable_Creator(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _newArray5815; 
		 java.lang.Object[] android.os.Parcelable_Creator.newArray(int arg0) 
		{ 
			if (GetType() == typeof(android.os.__Parcelable_Creator)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _newArray5815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.__Parcelable_Creator.staticClass, _newArray5815, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _createFromParcel5816; 
		 java.lang.Object android.os.Parcelable_Creator.createFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.__Parcelable_Creator)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _createFromParcel5816, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.__Parcelable_Creator.staticClass, _createFromParcel5816, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.__Parcelable_Creator.staticClass = @__class; 
			global::android.os.__Parcelable_Creator._newArray5815 = @__env.GetMethodID(global::android.os.__Parcelable_Creator.staticClass, "android.os.Parcelable_Creator.newArray", "(I)[Ljava/lang/Object;"); 
			global::android.os.__Parcelable_Creator._createFromParcel5816 = @__env.GetMethodID(global::android.os.__Parcelable_Creator.staticClass, "android.os.Parcelable_Creator.createFromParcel", "(Landroid/os/Parcel;)Ljava/lang/Object;"); 
		} 
	} 
} 
