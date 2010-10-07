namespace android.content
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SyncAdapterType : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static SyncAdapterType()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.content.SyncAdapterType), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.content.SyncAdapterType(@__env);
			}
		}
		protected SyncAdapterType(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _equals1682;
		public override bool equals(java.lang.Object arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.SyncAdapterType._equals1682, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._equals1682, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString1683;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.content.SyncAdapterType._toString1683));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._toString1683));
		}
		internal static global::net.sf.jni4net.jni.MethodId _hashCode1684;
		public override int hashCode() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.SyncAdapterType._hashCode1684);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._hashCode1684);
		}
		internal static global::net.sf.jni4net.jni.MethodId _supportsUploading1685;
		public virtual bool supportsUploading() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.SyncAdapterType._supportsUploading1685);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._supportsUploading1685);
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel1686;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.content.SyncAdapterType._writeToParcel1686, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._writeToParcel1686, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents1687;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.content.SyncAdapterType._describeContents1687);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._describeContents1687);
		}
		internal static global::net.sf.jni4net.jni.MethodId _newKey1688;
		public static global::android.content.SyncAdapterType newKey(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.content.SyncAdapterType>(@__env, @__env.CallStaticObjectMethodPtr(android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._newKey1688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isUserVisible1689;
		public virtual bool isUserVisible() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.content.SyncAdapterType._isUserVisible1689);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._isUserVisible1689);
		}
		internal static global::net.sf.jni4net.jni.MethodId _SyncAdapterType1690;
		public SyncAdapterType(java.lang.String arg0, java.lang.String arg1, bool arg2, bool arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._SyncAdapterType1690, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _SyncAdapterType1691;
		public SyncAdapterType(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._SyncAdapterType1691, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.FieldId _authority1692;
		public global::java.lang.String authority
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _accountType1693;
		public global::java.lang.String accountType
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _isKey1694;
		public bool isKey
		{
			get
			{
				return default(bool);
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR1695;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.content.SyncAdapterType.staticClass = @__class;
			global::android.content.SyncAdapterType._equals1682 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.SyncAdapterType._toString1683 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.SyncAdapterType._hashCode1684 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "hashCode", "()I");
			global::android.content.SyncAdapterType._supportsUploading1685 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "supportsUploading", "()Z");
			global::android.content.SyncAdapterType._writeToParcel1686 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.SyncAdapterType._describeContents1687 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "describeContents", "()I");
			global::android.content.SyncAdapterType._newKey1688 = @__env.GetStaticMethodID(global::android.content.SyncAdapterType.staticClass, "newKey", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SyncAdapterType;");
			global::android.content.SyncAdapterType._isUserVisible1689 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "isUserVisible", "()Z");
			global::android.content.SyncAdapterType._SyncAdapterType1690 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ZZ)V");
			global::android.content.SyncAdapterType._SyncAdapterType1691 = @__env.GetMethodID(global::android.content.SyncAdapterType.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
