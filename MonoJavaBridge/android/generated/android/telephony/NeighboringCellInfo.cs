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
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.NeighboringCellInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.telephony.NeighboringCellInfo._toString11776) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel11777;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.telephony.NeighboringCellInfo._writeToParcel11777, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents11778;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "describeContents", "()I", ref global::android.telephony.NeighboringCellInfo._describeContents11778);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "getRssi", "()I", ref global::android.telephony.NeighboringCellInfo._getRssi11779);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "getLac", "()I", ref global::android.telephony.NeighboringCellInfo._getLac11780);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "getCid", "()I", ref global::android.telephony.NeighboringCellInfo._getCid11781);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "getPsc", "()I", ref global::android.telephony.NeighboringCellInfo._getPsc11782);
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
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "getNetworkType", "()I", ref global::android.telephony.NeighboringCellInfo._getNetworkType11783);
		}
		internal static global::MonoJavaBridge.MethodId _setCid11784;
		public virtual void setCid(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "setCid", "(I)V", ref global::android.telephony.NeighboringCellInfo._setCid11784, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRssi11785;
		public virtual void setRssi(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "setRssi", "(I)V", ref global::android.telephony.NeighboringCellInfo._setRssi11785, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo11786;
		public NeighboringCellInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11786.native == global::System.IntPtr.Zero)
				global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11786 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11786);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo11787;
		public NeighboringCellInfo(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11787.native == global::System.IntPtr.Zero)
				global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11787 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11787, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo11788;
		public NeighboringCellInfo(int arg0, java.lang.String arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11788.native == global::System.IntPtr.Zero)
				global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11788 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(ILjava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo11789;
		public NeighboringCellInfo(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11789.native == global::System.IntPtr.Zero)
				global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11789 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
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
			global::android.telephony.NeighboringCellInfo._CREATOR11792 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
		internal static void InitJNI()
		{
		}
	}
}
