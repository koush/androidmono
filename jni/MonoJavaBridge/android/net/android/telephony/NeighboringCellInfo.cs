namespace android.telephony 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class NeighboringCellInfo : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static NeighboringCellInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.telephony.NeighboringCellInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _toString6152; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.NeighboringCellInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString6152)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.telephony.NeighboringCellInfo.staticClass, _toString6152)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6153; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.NeighboringCellInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel6153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.NeighboringCellInfo.staticClass, _writeToParcel6153, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents6154; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.NeighboringCellInfo)) 
				return @__env.CallIntMethod(this, _describeContents6154); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.NeighboringCellInfo.staticClass, _describeContents6154); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getRssi6155; 
		public virtual int getRssi() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.NeighboringCellInfo)) 
				return @__env.CallIntMethod(this, _getRssi6155); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.NeighboringCellInfo.staticClass, _getRssi6155); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLac6156; 
		public virtual int getLac() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.NeighboringCellInfo)) 
				return @__env.CallIntMethod(this, _getLac6156); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.NeighboringCellInfo.staticClass, _getLac6156); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCid6157; 
		public virtual int getCid() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.NeighboringCellInfo)) 
				return @__env.CallIntMethod(this, _getCid6157); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.NeighboringCellInfo.staticClass, _getCid6157); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPsc6158; 
		public virtual int getPsc() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.NeighboringCellInfo)) 
				return @__env.CallIntMethod(this, _getPsc6158); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.NeighboringCellInfo.staticClass, _getPsc6158); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getNetworkType6159; 
		public virtual int getNetworkType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.NeighboringCellInfo)) 
				return @__env.CallIntMethod(this, _getNetworkType6159); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.telephony.NeighboringCellInfo.staticClass, _getNetworkType6159); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setCid6160; 
		public virtual void setCid(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.NeighboringCellInfo)) 
				@__env.CallVoidMethod(this, _setCid6160, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.NeighboringCellInfo.staticClass, _setCid6160, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setRssi6161; 
		public virtual void setRssi(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.telephony.NeighboringCellInfo)) 
				@__env.CallVoidMethod(this, _setRssi6161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.telephony.NeighboringCellInfo.staticClass, _setRssi6161, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NeighboringCellInfo6162; 
		public NeighboringCellInfo()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, _NeighboringCellInfo6162, this); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NeighboringCellInfo6163; 
		public NeighboringCellInfo(int arg0, int arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, _NeighboringCellInfo6163, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NeighboringCellInfo6164; 
		public NeighboringCellInfo(int arg0, java.lang.String arg1, int arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, _NeighboringCellInfo6164, this, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _NeighboringCellInfo6165; 
		public NeighboringCellInfo(android.os.Parcel arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.telephony.NeighboringCellInfo.staticClass, _NeighboringCellInfo6165, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
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
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR6166; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.telephony.NeighboringCellInfo.staticClass = @__class; 
			global::android.telephony.NeighboringCellInfo._toString6152 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.telephony.NeighboringCellInfo._writeToParcel6153 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.telephony.NeighboringCellInfo._describeContents6154 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "describeContents", "()I"); 
			global::android.telephony.NeighboringCellInfo._getRssi6155 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "getRssi", "()I"); 
			global::android.telephony.NeighboringCellInfo._getLac6156 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "getLac", "()I"); 
			global::android.telephony.NeighboringCellInfo._getCid6157 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "getCid", "()I"); 
			global::android.telephony.NeighboringCellInfo._getPsc6158 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "getPsc", "()I"); 
			global::android.telephony.NeighboringCellInfo._getNetworkType6159 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "getNetworkType", "()I"); 
			global::android.telephony.NeighboringCellInfo._setCid6160 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "setCid", "(I)V"); 
			global::android.telephony.NeighboringCellInfo._setRssi6161 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "setRssi", "(I)V"); 
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo6162 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "()V"); 
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo6163 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(II)V"); 
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo6164 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(ILjava/lang/String;I)V"); 
			global::android.telephony.NeighboringCellInfo._NeighboringCellInfo6165 = @__env.GetMethodID(global::android.telephony.NeighboringCellInfo.staticClass, "<init>", "(Landroid/os/Parcel;)V"); 
		} 
	} 
} 
