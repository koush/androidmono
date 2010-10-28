namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NeighboringCellInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NeighboringCellInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString11776;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._toString11776)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._toString11776)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel11777;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._writeToParcel11777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._writeToParcel11777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents11778;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._describeContents11778);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._describeContents11778);
		}
		public new int Rssi
		{
			get
			{
				return getRssi();
			}
			set
			{
				setRssi(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getRssi11779;
		public virtual int getRssi()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._getRssi11779);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getRssi11779);
		}
		public new int Lac
		{
			get
			{
				return getLac();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLac11780;
		public virtual int getLac()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._getLac11780);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getLac11780);
		}
		public new int Cid
		{
			get
			{
				return getCid();
			}
			set
			{
				setCid(value);
			}
		}
		internal static global::MonoJavaBridge.MethodId _getCid11781;
		public virtual int getCid()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._getCid11781);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getCid11781);
		}
		public new int Psc
		{
			get
			{
				return getPsc();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPsc11782;
		public virtual int getPsc()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._getPsc11782);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getPsc11782);
		}
		public new int NetworkType
		{
			get
			{
				return getNetworkType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkType11783;
		public virtual int getNetworkType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._getNetworkType11783);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getNetworkType11783);
		}
		internal static global::MonoJavaBridge.MethodId _setCid11784;
		public virtual void setCid(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._setCid11784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._setCid11784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRssi11785;
		public virtual void setRssi(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._setRssi11785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._setRssi11785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo11786;
		public NeighboringCellInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11786);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo11787;
		public NeighboringCellInfo(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo11788;
		public NeighboringCellInfo(int arg0, java.lang.String arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo11789;
		public NeighboringCellInfo(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			Init(@__env, handle);
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
		internal static global::MonoJavaBridge.FieldId _CREATOR11792;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.telephony.NeighboringCellInfo.staticClass, _CREATOR11792)) as android.os.Parcelable_Creator;
			}
		}
		static NeighboringCellInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.NeighboringCellInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/NeighboringCellInfo"));
			global::android.telephony.NeighboringCellInfo._toString11776 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.NeighboringCellInfo._writeToParcel11777 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.telephony.NeighboringCellInfo._describeContents11778 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "describeContents", "()I");
			global::android.telephony.NeighboringCellInfo._getRssi11779 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "getRssi", "()I");
			global::android.telephony.NeighboringCellInfo._getLac11780 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "getLac", "()I");
			global::android.telephony.NeighboringCellInfo._getCid11781 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "getCid", "()I");
			global::android.telephony.NeighboringCellInfo._getPsc11782 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "getPsc", "()I");
			global::android.telephony.NeighboringCellInfo._getNetworkType11783 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "getNetworkType", "()I");
			global::android.telephony.NeighboringCellInfo._setCid11784 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "setCid", "(I)V");
			global::android.telephony.NeighboringCellInfo._setRssi11785 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "setRssi", "(I)V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11786 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "()V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11787 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(II)V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11788 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(ILjava/lang/String;I)V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11789 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.telephony.NeighboringCellInfo._CREATOR11792 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
