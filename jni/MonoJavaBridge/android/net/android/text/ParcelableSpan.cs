namespace android.text 
{ 
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()] 
	public interface ParcelableSpan : android.os.Parcelable
	{ 
		int getSpanTypeId(); 
	} 

	public partial class ParcelableSpan_ 
	{ 
		public static global::java.lang.Class _class 
		{ 
			get { return __ParcelableSpan.staticClass; } 
		} 
	} 

	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class __ParcelableSpan : java.lang.Object, ParcelableSpan
	{ 
		internal static global::java.lang.Class staticClass; 
		static __ParcelableSpan() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.text.__ParcelableSpan), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.text.__ParcelableSpan(@__env); 
			} 
		} 
		internal __ParcelableSpan(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSpanTypeId6858; 
		 int android.text.ParcelableSpan.getSpanTypeId() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.__ParcelableSpan)) 
				return @__env.CallIntMethod(this, _getSpanTypeId6858); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.__ParcelableSpan.staticClass, _getSpanTypeId6858); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6859; 
		 void android.os.Parcelable.writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.__ParcelableSpan)) 
				@__env.CallVoidMethod(this, _writeToParcel6859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.text.__ParcelableSpan.staticClass, _writeToParcel6859, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents6860; 
		 int android.os.Parcelable.describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.text.__ParcelableSpan)) 
				return @__env.CallIntMethod(this, _describeContents6860); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.text.__ParcelableSpan.staticClass, _describeContents6860); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.text.__ParcelableSpan.staticClass = @__class; 
			global::android.text.__ParcelableSpan._getSpanTypeId6858 = @__env.GetMethodID(global::android.text.__ParcelableSpan.staticClass, "android.text.ParcelableSpan.getSpanTypeId", "()I"); 
			global::android.text.__ParcelableSpan._writeToParcel6859 = @__env.GetMethodID(global::android.text.__ParcelableSpan.staticClass, "android.os.Parcelable.writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.text.__ParcelableSpan._describeContents6860 = @__env.GetMethodID(global::android.text.__ParcelableSpan.staticClass, "android.os.Parcelable.describeContents", "()I"); 
		} 
	} 
} 
