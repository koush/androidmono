namespace android.content
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SyncAdapterType : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SyncAdapterType()
		{
			InitJNI();
		}
		protected SyncAdapterType(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _equals1776;
		public override bool equals(java.lang.Object arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SyncAdapterType._equals1776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._equals1776, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString1777;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.content.SyncAdapterType._toString1777)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._toString1777)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode1778;
		public override int hashCode() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.SyncAdapterType._hashCode1778);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._hashCode1778);
		}
		internal static global::MonoJavaBridge.MethodId _supportsUploading1779;
		public virtual bool supportsUploading() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SyncAdapterType._supportsUploading1779);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._supportsUploading1779);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel1780;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.content.SyncAdapterType._writeToParcel1780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._writeToParcel1780, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents1781;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.content.SyncAdapterType._describeContents1781);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._describeContents1781);
		}
		internal static global::MonoJavaBridge.MethodId _newKey1782;
		public static global::android.content.SyncAdapterType newKey(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._newKey1782, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.content.SyncAdapterType;
		}
		internal static global::MonoJavaBridge.MethodId _isUserVisible1783;
		public virtual bool isUserVisible() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.content.SyncAdapterType._isUserVisible1783);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._isUserVisible1783);
		}
		internal static global::MonoJavaBridge.MethodId _SyncAdapterType1784;
		public SyncAdapterType(java.lang.String arg0, java.lang.String arg1, bool arg2, bool arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._SyncAdapterType1784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _SyncAdapterType1785;
		public SyncAdapterType(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.content.SyncAdapterType.staticClass, global::android.content.SyncAdapterType._SyncAdapterType1785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.FieldId _authority1786;
		public global::java.lang.String authority
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _accountType1787;
		public global::java.lang.String accountType
		{
			get
			{
				return default(global::java.lang.String);
			}
		}
		internal static global::MonoJavaBridge.FieldId _isKey1788;
		public bool isKey
		{
			get
			{
				return default(bool);
			}
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR1789;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.content.SyncAdapterType.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/content/SyncAdapterType"));
			global::android.content.SyncAdapterType._equals1776 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.content.SyncAdapterType._toString1777 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "toString", "()Ljava/lang/String;");
			global::android.content.SyncAdapterType._hashCode1778 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "hashCode", "()I");
			global::android.content.SyncAdapterType._supportsUploading1779 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "supportsUploading", "()Z");
			global::android.content.SyncAdapterType._writeToParcel1780 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.content.SyncAdapterType._describeContents1781 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "describeContents", "()I");
			global::android.content.SyncAdapterType._newKey1782 = @__env.GetStaticMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "newKey", "(Ljava/lang/String;Ljava/lang/String;)Landroid/content/SyncAdapterType;");
			global::android.content.SyncAdapterType._isUserVisible1783 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "isUserVisible", "()Z");
			global::android.content.SyncAdapterType._SyncAdapterType1784 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "<init>", "(Ljava/lang/String;Ljava/lang/String;ZZ)V");
			global::android.content.SyncAdapterType._SyncAdapterType1785 = @__env.GetMethodIDNoThrow(global::android.content.SyncAdapterType.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
