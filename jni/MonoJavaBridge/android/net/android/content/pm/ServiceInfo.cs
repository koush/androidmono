namespace android.content.pm 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class ServiceInfo : android.content.pm.ComponentInfo, android.os.Parcelable
	{ 
		internal new static global::java.lang.Class staticClass; 
		static ServiceInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.content.pm.ServiceInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.content.pm.ServiceInfo(@__env); 
			} 
		} 
		protected ServiceInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString1803; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ServiceInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString1803)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.content.pm.ServiceInfo.staticClass, _toString1803)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _dump1804; 
		public virtual void dump(android.util.Printer arg0, java.lang.String arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ServiceInfo)) 
				@__env.CallVoidMethod(this, _dump1804, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.ServiceInfo.staticClass, _dump1804, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1805; 
		public override void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ServiceInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel1805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.content.pm.ServiceInfo.staticClass, _writeToParcel1805, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1806; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.content.pm.ServiceInfo)) 
				return @__env.CallIntMethod(this, _describeContents1806); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.content.pm.ServiceInfo.staticClass, _describeContents1806); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServiceInfo1807; 
		public ServiceInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.ServiceInfo.staticClass, _ServiceInfo1807, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _ServiceInfo1808; 
		public ServiceInfo(android.content.pm.ServiceInfo arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.content.pm.ServiceInfo.staticClass, _ServiceInfo1808, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _permission1809; 
		public java.lang.String permission
		{ 
			get 
			{ 
				return default(java.lang.String); 
			} 
			set 
			{ 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1810; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.content.pm.ServiceInfo.staticClass = @__class; 
			global::android.content.pm.ServiceInfo._toString1803 = @__env.GetMethodID(global::android.content.pm.ServiceInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.content.pm.ServiceInfo._dump1804 = @__env.GetMethodID(global::android.content.pm.ServiceInfo.staticClass, "dump", "(Landroid/util/Printer;Ljava/lang/String;)V"); 
			global::android.content.pm.ServiceInfo._writeToParcel1805 = @__env.GetMethodID(global::android.content.pm.ServiceInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.content.pm.ServiceInfo._describeContents1806 = @__env.GetMethodID(global::android.content.pm.ServiceInfo.staticClass, "describeContents", "()I"); 
			global::android.content.pm.ServiceInfo._ServiceInfo1807 = @__env.GetMethodID(global::android.content.pm.ServiceInfo.staticClass, "<init>", "()V"); 
			global::android.content.pm.ServiceInfo._ServiceInfo1808 = @__env.GetMethodID(global::android.content.pm.ServiceInfo.staticClass, "<init>", "(Landroid/content/pm/ServiceInfo;)V"); 
		} 
	} 
} 
