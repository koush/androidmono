namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NeighboringCellInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NeighboringCellInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.telephony.NeighboringCellInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.telephony.NeighboringCellInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.telephony.NeighboringCellInfo._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "describeContents", "()I", ref global::android.telephony.NeighboringCellInfo._m2);
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
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int getRssi()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "getRssi", "()I", ref global::android.telephony.NeighboringCellInfo._m3);
		}
		public new int Lac
		{
			get
			{
				return getLac();
			}
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual int getLac()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "getLac", "()I", ref global::android.telephony.NeighboringCellInfo._m4);
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
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual int getCid()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "getCid", "()I", ref global::android.telephony.NeighboringCellInfo._m5);
		}
		public new int Psc
		{
			get
			{
				return getPsc();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int getPsc()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "getPsc", "()I", ref global::android.telephony.NeighboringCellInfo._m6);
		}
		public new int NetworkType
		{
			get
			{
				return getNetworkType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual int getNetworkType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "getNetworkType", "()I", ref global::android.telephony.NeighboringCellInfo._m7);
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual void setCid(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "setCid", "(I)V", ref global::android.telephony.NeighboringCellInfo._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual void setRssi(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.telephony.NeighboringCellInfo.staticClass, "setRssi", "(I)V", ref global::android.telephony.NeighboringCellInfo._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public NeighboringCellInfo() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.NeighboringCellInfo._m10.native == global::System.IntPtr.Zero)
				global::android.telephony.NeighboringCellInfo._m10 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._m10);
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public NeighboringCellInfo(int arg0, int arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.NeighboringCellInfo._m11.native == global::System.IntPtr.Zero)
				global::android.telephony.NeighboringCellInfo._m11 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(II)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public NeighboringCellInfo(int arg0, java.lang.String arg1, int arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.NeighboringCellInfo._m12.native == global::System.IntPtr.Zero)
				global::android.telephony.NeighboringCellInfo._m12 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(ILjava/lang/String;I)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public NeighboringCellInfo(android.os.Parcel arg0) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.telephony.NeighboringCellInfo._m13.native == global::System.IntPtr.Zero)
				global::android.telephony.NeighboringCellInfo._m13 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR5072;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.telephony.NeighboringCellInfo.staticClass, _CREATOR5072)) as android.os.Parcelable_Creator;
			}
		}
		static NeighboringCellInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.NeighboringCellInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/NeighboringCellInfo"));
			global::android.telephony.NeighboringCellInfo._CREATOR5072 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
