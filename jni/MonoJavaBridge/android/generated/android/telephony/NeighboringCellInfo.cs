namespace android.telephony
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NeighboringCellInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NeighboringCellInfo()
		{
			InitJNI();
		}
		protected NeighboringCellInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::MonoJavaBridge.MethodId _toString7344;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._toString7344)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._toString7344)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7345;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._writeToParcel7345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._writeToParcel7345, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents7346;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._describeContents7346);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._describeContents7346);
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
		internal static global::MonoJavaBridge.MethodId _getRssi7347;
		public virtual int getRssi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._getRssi7347);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getRssi7347);
		}
		public new int Lac
		{
			get
			{
				return getLac();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLac7348;
		public virtual int getLac() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._getLac7348);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getLac7348);
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
		internal static global::MonoJavaBridge.MethodId _getCid7349;
		public virtual int getCid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._getCid7349);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getCid7349);
		}
		public new int Psc
		{
			get
			{
				return getPsc();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPsc7350;
		public virtual int getPsc() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._getPsc7350);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getPsc7350);
		}
		public new int NetworkType
		{
			get
			{
				return getNetworkType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkType7351;
		public virtual int getNetworkType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._getNetworkType7351);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getNetworkType7351);
		}
		internal static global::MonoJavaBridge.MethodId _setCid7352;
		public virtual void setCid(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._setCid7352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._setCid7352, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRssi7353;
		public virtual void setRssi(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._setRssi7353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._setRssi7353, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo7354;
		public NeighboringCellInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7354);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo7355;
		public NeighboringCellInfo(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7355, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo7356;
		public NeighboringCellInfo(int arg0, java.lang.String arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7356, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo7357;
		public NeighboringCellInfo(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7357, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR7358;
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
			global::android.telephony.NeighboringCellInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/NeighboringCellInfo"));
			global::android.telephony.NeighboringCellInfo._toString7344 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.NeighboringCellInfo._writeToParcel7345 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.telephony.NeighboringCellInfo._describeContents7346 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "describeContents", "()I");
			global::android.telephony.NeighboringCellInfo._getRssi7347 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "getRssi", "()I");
			global::android.telephony.NeighboringCellInfo._getLac7348 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "getLac", "()I");
			global::android.telephony.NeighboringCellInfo._getCid7349 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "getCid", "()I");
			global::android.telephony.NeighboringCellInfo._getPsc7350 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "getPsc", "()I");
			global::android.telephony.NeighboringCellInfo._getNetworkType7351 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "getNetworkType", "()I");
			global::android.telephony.NeighboringCellInfo._setCid7352 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "setCid", "(I)V");
			global::android.telephony.NeighboringCellInfo._setRssi7353 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "setRssi", "(I)V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7354 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "()V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7355 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(II)V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7356 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(ILjava/lang/String;I)V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo7357 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
		}
	}
}
