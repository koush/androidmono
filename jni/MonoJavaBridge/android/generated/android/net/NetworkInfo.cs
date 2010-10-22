namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NetworkInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static NetworkInfo()
		{
			InitJNI();
		}
		protected NetworkInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class DetailedState : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static DetailedState()
			{
				InitJNI();
			}
			internal DetailedState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values7671;
			public static global::android.net.NetworkInfo.DetailedState[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.NetworkInfo.DetailedState>(@__env.CallStaticObjectMethod(android.net.NetworkInfo.DetailedState.staticClass, global::android.net.NetworkInfo.DetailedState._values7671)) as android.net.NetworkInfo.DetailedState[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf7672;
			public static global::android.net.NetworkInfo.DetailedState valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.CallStaticObjectMethod(android.net.NetworkInfo.DetailedState.staticClass, global::android.net.NetworkInfo.DetailedState._valueOf7672, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.NetworkInfo.DetailedState;
			}
			internal static global::MonoJavaBridge.FieldId _AUTHENTICATING7673;
			public static global::android.net.NetworkInfo.DetailedState AUTHENTICATING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _AUTHENTICATING7673)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTED7674;
			public static global::android.net.NetworkInfo.DetailedState CONNECTED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _CONNECTED7674)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTING7675;
			public static global::android.net.NetworkInfo.DetailedState CONNECTING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _CONNECTING7675)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTED7676;
			public static global::android.net.NetworkInfo.DetailedState DISCONNECTED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _DISCONNECTED7676)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTING7677;
			public static global::android.net.NetworkInfo.DetailedState DISCONNECTING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _DISCONNECTING7677)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FAILED7678;
			public static global::android.net.NetworkInfo.DetailedState FAILED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _FAILED7678)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IDLE7679;
			public static global::android.net.NetworkInfo.DetailedState IDLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _IDLE7679)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OBTAINING_IPADDR7680;
			public static global::android.net.NetworkInfo.DetailedState OBTAINING_IPADDR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _OBTAINING_IPADDR7680)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SCANNING7681;
			public static global::android.net.NetworkInfo.DetailedState SCANNING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _SCANNING7681)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUSPENDED7682;
			public static global::android.net.NetworkInfo.DetailedState SUSPENDED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _SUSPENDED7682)) as android.net.NetworkInfo.DetailedState;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.NetworkInfo.DetailedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/NetworkInfo$DetailedState"));
				global::android.net.NetworkInfo.DetailedState._values7671 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "values", "()[Landroid/net/NetworkInfo/DetailedState;");
				global::android.net.NetworkInfo.DetailedState._valueOf7672 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._AUTHENTICATING7673 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "AUTHENTICATING", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._CONNECTED7674 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "CONNECTED", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._CONNECTING7675 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "CONNECTING", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._DISCONNECTED7676 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "DISCONNECTED", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._DISCONNECTING7677 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "DISCONNECTING", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._FAILED7678 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "FAILED", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._IDLE7679 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "IDLE", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._OBTAINING_IPADDR7680 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "OBTAINING_IPADDR", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._SCANNING7681 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "SCANNING", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._SUSPENDED7682 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "SUSPENDED", "Landroid/net/NetworkInfo$DetailedState;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class State : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static State()
			{
				InitJNI();
			}
			internal State(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _values7683;
			public static global::android.net.NetworkInfo.State[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.NetworkInfo.State>(@__env.CallStaticObjectMethod(android.net.NetworkInfo.State.staticClass, global::android.net.NetworkInfo.State._values7683)) as android.net.NetworkInfo.State[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf7684;
			public static global::android.net.NetworkInfo.State valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.CallStaticObjectMethod(android.net.NetworkInfo.State.staticClass, global::android.net.NetworkInfo.State._valueOf7684, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.NetworkInfo.State;
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTED7685;
			public static global::android.net.NetworkInfo.State CONNECTED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _CONNECTED7685)) as android.net.NetworkInfo.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTING7686;
			public static global::android.net.NetworkInfo.State CONNECTING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _CONNECTING7686)) as android.net.NetworkInfo.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTED7687;
			public static global::android.net.NetworkInfo.State DISCONNECTED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _DISCONNECTED7687)) as android.net.NetworkInfo.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTING7688;
			public static global::android.net.NetworkInfo.State DISCONNECTING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _DISCONNECTING7688)) as android.net.NetworkInfo.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUSPENDED7689;
			public static global::android.net.NetworkInfo.State SUSPENDED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _SUSPENDED7689)) as android.net.NetworkInfo.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNKNOWN7690;
			public static global::android.net.NetworkInfo.State UNKNOWN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _UNKNOWN7690)) as android.net.NetworkInfo.State;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.NetworkInfo.State.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/NetworkInfo$State"));
				global::android.net.NetworkInfo.State._values7683 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "values", "()[Landroid/net/NetworkInfo/State;");
				global::android.net.NetworkInfo.State._valueOf7684 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._CONNECTED7685 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "CONNECTED", "Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._CONNECTING7686 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "CONNECTING", "Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._DISCONNECTED7687 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "DISCONNECTED", "Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._DISCONNECTING7688 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "DISCONNECTING", "Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._SUSPENDED7689 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "SUSPENDED", "Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._UNKNOWN7690 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "UNKNOWN", "Landroid/net/NetworkInfo$State;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString7691;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._toString7691)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._toString7691)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getState7692;
		public virtual global::android.net.NetworkInfo.State getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getState7692)) as android.net.NetworkInfo.State;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getState7692)) as android.net.NetworkInfo.State;
		}
		public new int Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType7693;
		public virtual int getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.NetworkInfo._getType7693);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getType7693);
		}
		public new global::java.lang.String TypeName
		{
			get
			{
				return getTypeName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeName7694;
		public virtual global::java.lang.String getTypeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getTypeName7694)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getTypeName7694)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAvailable7695;
		public virtual bool isAvailable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo._isAvailable7695);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isAvailable7695);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7696;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.NetworkInfo._writeToParcel7696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._writeToParcel7696, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents7697;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.NetworkInfo._describeContents7697);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._describeContents7697);
		}
		public new global::java.lang.String Reason
		{
			get
			{
				return getReason();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReason7698;
		public virtual global::java.lang.String getReason() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getReason7698)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getReason7698)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isConnected7699;
		public virtual bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo._isConnected7699);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isConnected7699);
		}
		internal static global::MonoJavaBridge.MethodId _isFailover7700;
		public virtual bool isFailover() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo._isFailover7700);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isFailover7700);
		}
		public new int Subtype
		{
			get
			{
				return getSubtype();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubtype7701;
		public virtual int getSubtype() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.NetworkInfo._getSubtype7701);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getSubtype7701);
		}
		public new global::java.lang.String SubtypeName
		{
			get
			{
				return getSubtypeName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubtypeName7702;
		public virtual global::java.lang.String getSubtypeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getSubtypeName7702)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getSubtypeName7702)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isConnectedOrConnecting7703;
		public virtual bool isConnectedOrConnecting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo._isConnectedOrConnecting7703);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isConnectedOrConnecting7703);
		}
		internal static global::MonoJavaBridge.MethodId _isRoaming7704;
		public virtual bool isRoaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo._isRoaming7704);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isRoaming7704);
		}
		internal static global::MonoJavaBridge.MethodId _getDetailedState7705;
		public virtual global::android.net.NetworkInfo.DetailedState getDetailedState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getDetailedState7705)) as android.net.NetworkInfo.DetailedState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getDetailedState7705)) as android.net.NetworkInfo.DetailedState;
		}
		public new global::java.lang.String ExtraInfo
		{
			get
			{
				return getExtraInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtraInfo7706;
		public virtual global::java.lang.String getExtraInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getExtraInfo7706)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getExtraInfo7706)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.NetworkInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/NetworkInfo"));
			global::android.net.NetworkInfo._toString7691 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.NetworkInfo._getState7692 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getState", "()Landroid/net/NetworkInfo$State;");
			global::android.net.NetworkInfo._getType7693 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getType", "()I");
			global::android.net.NetworkInfo._getTypeName7694 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getTypeName", "()Ljava/lang/String;");
			global::android.net.NetworkInfo._isAvailable7695 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "isAvailable", "()Z");
			global::android.net.NetworkInfo._writeToParcel7696 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.NetworkInfo._describeContents7697 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "describeContents", "()I");
			global::android.net.NetworkInfo._getReason7698 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getReason", "()Ljava/lang/String;");
			global::android.net.NetworkInfo._isConnected7699 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "isConnected", "()Z");
			global::android.net.NetworkInfo._isFailover7700 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "isFailover", "()Z");
			global::android.net.NetworkInfo._getSubtype7701 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getSubtype", "()I");
			global::android.net.NetworkInfo._getSubtypeName7702 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getSubtypeName", "()Ljava/lang/String;");
			global::android.net.NetworkInfo._isConnectedOrConnecting7703 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "isConnectedOrConnecting", "()Z");
			global::android.net.NetworkInfo._isRoaming7704 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "isRoaming", "()Z");
			global::android.net.NetworkInfo._getDetailedState7705 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getDetailedState", "()Landroid/net/NetworkInfo$DetailedState;");
			global::android.net.NetworkInfo._getExtraInfo7706 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getExtraInfo", "()Ljava/lang/String;");
		}
	}
}
