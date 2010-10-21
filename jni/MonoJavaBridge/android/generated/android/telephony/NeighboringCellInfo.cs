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
		internal static global::MonoJavaBridge.MethodId _toString11719;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._toString11719)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._toString11719)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel11720;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._writeToParcel11720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._writeToParcel11720, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents11721;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._describeContents11721);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._describeContents11721);
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
		internal static global::MonoJavaBridge.MethodId _getRssi11722;
		public virtual int getRssi() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._getRssi11722);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getRssi11722);
		}
		public new int Lac
		{
			get
			{
				return getLac();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getLac11723;
		public virtual int getLac() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._getLac11723);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getLac11723);
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
		internal static global::MonoJavaBridge.MethodId _getCid11724;
		public virtual int getCid() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._getCid11724);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getCid11724);
		}
		public new int Psc
		{
			get
			{
				return getPsc();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPsc11725;
		public virtual int getPsc() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._getPsc11725);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getPsc11725);
		}
		public new int NetworkType
		{
			get
			{
				return getNetworkType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNetworkType11726;
		public virtual int getNetworkType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._getNetworkType11726);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._getNetworkType11726);
		}
		internal static global::MonoJavaBridge.MethodId _setCid11727;
		public virtual void setCid(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._setCid11727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._setCid11727, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setRssi11728;
		public virtual void setRssi(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo._setRssi11728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._setRssi11728, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo11729;
		public NeighboringCellInfo()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11729);
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo11730;
		public NeighboringCellInfo(int arg0, int arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11730, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo11731;
		public NeighboringCellInfo(int arg0, java.lang.String arg1, int arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11731, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			Init(@__env, handle);
		}
		internal static global::MonoJavaBridge.MethodId _NeighboringCellInfo11732;
		public NeighboringCellInfo(android.os.Parcel arg0)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11732, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.FieldId _CREATOR11735;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.telephony.NeighboringCellInfo.staticClass, _CREATOR11735)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.telephony.NeighboringCellInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/telephony/NeighboringCellInfo"));
			global::android.telephony.NeighboringCellInfo._toString11719 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.telephony.NeighboringCellInfo._writeToParcel11720 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.telephony.NeighboringCellInfo._describeContents11721 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "describeContents", "()I");
			global::android.telephony.NeighboringCellInfo._getRssi11722 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "getRssi", "()I");
			global::android.telephony.NeighboringCellInfo._getLac11723 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "getLac", "()I");
			global::android.telephony.NeighboringCellInfo._getCid11724 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "getCid", "()I");
			global::android.telephony.NeighboringCellInfo._getPsc11725 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "getPsc", "()I");
			global::android.telephony.NeighboringCellInfo._getNetworkType11726 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "getNetworkType", "()I");
			global::android.telephony.NeighboringCellInfo._setCid11727 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "setCid", "(I)V");
			global::android.telephony.NeighboringCellInfo._setRssi11728 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "setRssi", "(I)V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11729 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "()V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11730 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(II)V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11731 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(ILjava/lang/String;I)V");
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo11732 = @__env.GetMethodIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V");
			global::android.telephony.NeighboringCellInfo._CREATOR11735 = @__env.GetStaticFieldIDNoThrow(global::android.telephony.NeighboringCellInfo.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
