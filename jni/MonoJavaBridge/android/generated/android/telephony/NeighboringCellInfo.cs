namespace android.telephony
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class NeighboringCellInfo : java.lang.Object, android.os.Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static NeighboringCellInfo()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.telephony.NeighboringCellInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.telephony.NeighboringCellInfo(@__env);
			}
		}
		protected NeighboringCellInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString7064;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.telephony.NeighboringCellInfo._toString7064));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._toString7064));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel7065;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.NeighboringCellInfo._writeToParcel7065, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._writeToParcel7065, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents7066;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.NeighboringCellInfo._describeContents7066);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._describeContents7066);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getRssi7067;
		public virtual int getRssi() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.NeighboringCellInfo._getRssi7067);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getRssi7067);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLac7068;
		public virtual int getLac() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.NeighboringCellInfo._getLac7068);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getLac7068);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCid7069;
		public virtual int getCid() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.NeighboringCellInfo._getCid7069);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getCid7069);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPsc7070;
		public virtual int getPsc() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.NeighboringCellInfo._getPsc7070);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getPsc7070);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkType7071;
		public virtual int getNetworkType() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.telephony.NeighboringCellInfo._getNetworkType7071);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getNetworkType7071);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setCid7072;
		public virtual void setCid(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.NeighboringCellInfo._setCid7072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._setCid7072, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setRssi7073;
		public virtual void setRssi(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.telephony.NeighboringCellInfo._setRssi7073, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._setRssi7073, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _NeighboringCellInfo7074;
		public NeighboringCellInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7074, this);
		}
		internal static global::net.sf.jni4net.jni.MethodId _NeighboringCellInfo7075;
		public NeighboringCellInfo(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7075, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _NeighboringCellInfo7076;
		public NeighboringCellInfo(int arg0, java.lang.String arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7076, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _NeighboringCellInfo7077;
		public NeighboringCellInfo(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7077, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		public static int UNKNOWN_RSSI
		{
			get
			{
				return 99;
			}
		}
		public static int UNKNOWN_CID
		{
			get
			{
				return -1;
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR7078;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.telephony.NeighboringCellInfo.staticClass = @__class;
			global::android.telephony.NeighboringCellInfo._toString7064 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.NeighboringCellInfo._writeToParcel7065 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.telephony.NeighboringCellInfo._describeContents7066 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "describeContents", "()I");
			global::android.telephony.NeighboringCellInfo._getRssi7067 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "getRssi", "()I");
			global::android.telephony.NeighboringCellInfo._getLac7068 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "getLac", "()I");
			global::android.telephony.NeighboringCellInfo._getCid7069 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "getCid", "()I");
			global::android.telephony.NeighboringCellInfo._getPsc7070 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "getPsc", "()I");
			global::android.telephony.NeighboringCellInfo._getNetworkType7071 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "getNetworkType", "()I");
			global::android.telephony.NeighboringCellInfo._setCid7072 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "setCid", "(I)V");
			global::android.telephony.NeighboringCellInfo._setRssi7073 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "setRssi", "(I)V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7074 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "()V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7075 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(II)V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7076 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(ILjava/lang/String;I)V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7077 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
