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
			internal static global::MonoJavaBridge.MethodId _values7710;
			public static global::android.net.NetworkInfo.DetailedState[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.NetworkInfo.DetailedState>(@__env.CallStaticObjectMethod(android.net.NetworkInfo.DetailedState.staticClass, global::android.net.NetworkInfo.DetailedState._values7710)) as android.net.NetworkInfo.DetailedState[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf7711;
			public static global::android.net.NetworkInfo.DetailedState valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.CallStaticObjectMethod(android.net.NetworkInfo.DetailedState.staticClass, global::android.net.NetworkInfo.DetailedState._valueOf7711, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.NetworkInfo.DetailedState;
			}
			internal static global::MonoJavaBridge.FieldId _AUTHENTICATING7712;
			public static global::android.net.NetworkInfo.DetailedState AUTHENTICATING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _AUTHENTICATING7712)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTED7713;
			public static global::android.net.NetworkInfo.DetailedState CONNECTED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _CONNECTED7713)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTING7714;
			public static global::android.net.NetworkInfo.DetailedState CONNECTING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _CONNECTING7714)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTED7715;
			public static global::android.net.NetworkInfo.DetailedState DISCONNECTED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _DISCONNECTED7715)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTING7716;
			public static global::android.net.NetworkInfo.DetailedState DISCONNECTING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _DISCONNECTING7716)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FAILED7717;
			public static global::android.net.NetworkInfo.DetailedState FAILED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _FAILED7717)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IDLE7718;
			public static global::android.net.NetworkInfo.DetailedState IDLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _IDLE7718)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OBTAINING_IPADDR7719;
			public static global::android.net.NetworkInfo.DetailedState OBTAINING_IPADDR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _OBTAINING_IPADDR7719)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SCANNING7720;
			public static global::android.net.NetworkInfo.DetailedState SCANNING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _SCANNING7720)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUSPENDED7721;
			public static global::android.net.NetworkInfo.DetailedState SUSPENDED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _SUSPENDED7721)) as android.net.NetworkInfo.DetailedState;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.NetworkInfo.DetailedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/NetworkInfo$DetailedState"));
				global::android.net.NetworkInfo.DetailedState._values7710 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "values", "()[Landroid/net/NetworkInfo/DetailedState;");
				global::android.net.NetworkInfo.DetailedState._valueOf7711 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._AUTHENTICATING7712 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "AUTHENTICATING", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._CONNECTED7713 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "CONNECTED", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._CONNECTING7714 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "CONNECTING", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._DISCONNECTED7715 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "DISCONNECTED", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._DISCONNECTING7716 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "DISCONNECTING", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._FAILED7717 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "FAILED", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._IDLE7718 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "IDLE", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._OBTAINING_IPADDR7719 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "OBTAINING_IPADDR", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._SCANNING7720 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "SCANNING", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._SUSPENDED7721 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "SUSPENDED", "Landroid/net/NetworkInfo$DetailedState;");
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
			internal static global::MonoJavaBridge.MethodId _values7722;
			public static global::android.net.NetworkInfo.State[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.NetworkInfo.State>(@__env.CallStaticObjectMethod(android.net.NetworkInfo.State.staticClass, global::android.net.NetworkInfo.State._values7722)) as android.net.NetworkInfo.State[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf7723;
			public static global::android.net.NetworkInfo.State valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.CallStaticObjectMethod(android.net.NetworkInfo.State.staticClass, global::android.net.NetworkInfo.State._valueOf7723, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.NetworkInfo.State;
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTED7724;
			public static global::android.net.NetworkInfo.State CONNECTED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _CONNECTED7724)) as android.net.NetworkInfo.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTING7725;
			public static global::android.net.NetworkInfo.State CONNECTING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _CONNECTING7725)) as android.net.NetworkInfo.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTED7726;
			public static global::android.net.NetworkInfo.State DISCONNECTED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _DISCONNECTED7726)) as android.net.NetworkInfo.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTING7727;
			public static global::android.net.NetworkInfo.State DISCONNECTING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _DISCONNECTING7727)) as android.net.NetworkInfo.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUSPENDED7728;
			public static global::android.net.NetworkInfo.State SUSPENDED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _SUSPENDED7728)) as android.net.NetworkInfo.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNKNOWN7729;
			public static global::android.net.NetworkInfo.State UNKNOWN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _UNKNOWN7729)) as android.net.NetworkInfo.State;
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.NetworkInfo.State.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/NetworkInfo$State"));
				global::android.net.NetworkInfo.State._values7722 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "values", "()[Landroid/net/NetworkInfo/State;");
				global::android.net.NetworkInfo.State._valueOf7723 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._CONNECTED7724 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "CONNECTED", "Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._CONNECTING7725 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "CONNECTING", "Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._DISCONNECTED7726 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "DISCONNECTED", "Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._DISCONNECTING7727 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "DISCONNECTING", "Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._SUSPENDED7728 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "SUSPENDED", "Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._UNKNOWN7729 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "UNKNOWN", "Landroid/net/NetworkInfo$State;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString7730;
		public override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._toString7730)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._toString7730)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getState7731;
		public virtual global::android.net.NetworkInfo.State getState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getState7731)) as android.net.NetworkInfo.State;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getState7731)) as android.net.NetworkInfo.State;
		}
		public new int Type
		{
			get
			{
				return getType();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getType7732;
		public virtual int getType()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.NetworkInfo._getType7732);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getType7732);
		}
		public new global::java.lang.String TypeName
		{
			get
			{
				return getTypeName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getTypeName7733;
		public virtual global::java.lang.String getTypeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getTypeName7733)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getTypeName7733)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAvailable7734;
		public virtual bool isAvailable()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo._isAvailable7734);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isAvailable7734);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel7735;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.NetworkInfo._writeToParcel7735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._writeToParcel7735, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents7736;
		public virtual int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.NetworkInfo._describeContents7736);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._describeContents7736);
		}
		public new global::java.lang.String Reason
		{
			get
			{
				return getReason();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getReason7737;
		public virtual global::java.lang.String getReason()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getReason7737)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getReason7737)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isConnected7738;
		public virtual bool isConnected()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo._isConnected7738);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isConnected7738);
		}
		internal static global::MonoJavaBridge.MethodId _isFailover7739;
		public virtual bool isFailover()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo._isFailover7739);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isFailover7739);
		}
		public new int Subtype
		{
			get
			{
				return getSubtype();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubtype7740;
		public virtual int getSubtype()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.NetworkInfo._getSubtype7740);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getSubtype7740);
		}
		public new global::java.lang.String SubtypeName
		{
			get
			{
				return getSubtypeName();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSubtypeName7741;
		public virtual global::java.lang.String getSubtypeName()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getSubtypeName7741)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getSubtypeName7741)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isConnectedOrConnecting7742;
		public virtual bool isConnectedOrConnecting()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo._isConnectedOrConnecting7742);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isConnectedOrConnecting7742);
		}
		internal static global::MonoJavaBridge.MethodId _isRoaming7743;
		public virtual bool isRoaming()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo._isRoaming7743);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isRoaming7743);
		}
		internal static global::MonoJavaBridge.MethodId _getDetailedState7744;
		public virtual global::android.net.NetworkInfo.DetailedState getDetailedState()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getDetailedState7744)) as android.net.NetworkInfo.DetailedState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getDetailedState7744)) as android.net.NetworkInfo.DetailedState;
		}
		public new global::java.lang.String ExtraInfo
		{
			get
			{
				return getExtraInfo();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getExtraInfo7745;
		public virtual global::java.lang.String getExtraInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getExtraInfo7745)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getExtraInfo7745)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.NetworkInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/NetworkInfo"));
			global::android.net.NetworkInfo._toString7730 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.NetworkInfo._getState7731 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getState", "()Landroid/net/NetworkInfo$State;");
			global::android.net.NetworkInfo._getType7732 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getType", "()I");
			global::android.net.NetworkInfo._getTypeName7733 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getTypeName", "()Ljava/lang/String;");
			global::android.net.NetworkInfo._isAvailable7734 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "isAvailable", "()Z");
			global::android.net.NetworkInfo._writeToParcel7735 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.NetworkInfo._describeContents7736 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "describeContents", "()I");
			global::android.net.NetworkInfo._getReason7737 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getReason", "()Ljava/lang/String;");
			global::android.net.NetworkInfo._isConnected7738 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "isConnected", "()Z");
			global::android.net.NetworkInfo._isFailover7739 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "isFailover", "()Z");
			global::android.net.NetworkInfo._getSubtype7740 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getSubtype", "()I");
			global::android.net.NetworkInfo._getSubtypeName7741 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getSubtypeName", "()Ljava/lang/String;");
			global::android.net.NetworkInfo._isConnectedOrConnecting7742 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "isConnectedOrConnecting", "()Z");
			global::android.net.NetworkInfo._isRoaming7743 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "isRoaming", "()Z");
			global::android.net.NetworkInfo._getDetailedState7744 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getDetailedState", "()Landroid/net/NetworkInfo$DetailedState;");
			global::android.net.NetworkInfo._getExtraInfo7745 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getExtraInfo", "()Ljava/lang/String;");
		}
	}
}
