namespace android.accounts 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class Account : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Account() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.accounts.Account), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.accounts.Account(@__env); 
			} 
		} 
		protected Account(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode44; 
		public override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.accounts.Account._hashCode44); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.accounts.Account.staticClass, global::android.accounts.Account._hashCode44); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals45; 
		public override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.accounts.Account._equals45, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.accounts.Account.staticClass, global::android.accounts.Account._equals45, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString46; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.accounts.Account._toString46)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.accounts.Account.staticClass, global::android.accounts.Account._toString46)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel47; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.accounts.Account._writeToParcel47, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.accounts.Account.staticClass, global::android.accounts.Account._writeToParcel47, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents48; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.accounts.Account._describeContents48); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.accounts.Account.staticClass, global::android.accounts.Account._describeContents48); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Account49; 
		public Account(java.lang.String arg0, java.lang.String arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.Account.staticClass, global::android.accounts.Account._Account49, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Account50; 
		public Account(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.accounts.Account.staticClass, global::android.accounts.Account._Account50, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _name51; 
		public global::java.lang.String name
		{ 
			get 
			{ 
				return default(global::java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _type52; 
		public global::java.lang.String type
		{ 
			get 
			{ 
				return default(global::java.lang.String); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR53; 
		public static global::android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(global::android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.accounts.Account.staticClass = @__class; 
			global::android.accounts.Account._hashCode44 = @__env.GetMethodID(global::android.accounts.Account.staticClass, "hashCode", "()I"); 
			global::android.accounts.Account._equals45 = @__env.GetMethodID(global::android.accounts.Account.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.accounts.Account._toString46 = @__env.GetMethodID(global::android.accounts.Account.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.accounts.Account._writeToParcel47 = @__env.GetMethodID(global::android.accounts.Account.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.accounts.Account._describeContents48 = @__env.GetMethodID(global::android.accounts.Account.staticClass, "describeContents", "()I"); 
			global::android.accounts.Account._Account49 = @__env.GetMethodID(global::android.accounts.Account.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;)V"); 
			global::android.accounts.Account._Account50 = @__env.GetMethodID(global::android.accounts.Account.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
