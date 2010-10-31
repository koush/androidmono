namespace android.net
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class NetworkInfo : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected NetworkInfo(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class DetailedState : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal DetailedState(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.net.NetworkInfo.DetailedState[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.NetworkInfo.DetailedState._m0.native == global::System.IntPtr.Zero)
					global::android.net.NetworkInfo.DetailedState._m0 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "values", "()[Landroid/net/NetworkInfo/DetailedState;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.NetworkInfo.DetailedState>(@__env.CallStaticObjectMethod(android.net.NetworkInfo.DetailedState.staticClass, global::android.net.NetworkInfo.DetailedState._m0)) as android.net.NetworkInfo.DetailedState[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.net.NetworkInfo.DetailedState valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.NetworkInfo.DetailedState._m1.native == global::System.IntPtr.Zero)
					global::android.net.NetworkInfo.DetailedState._m1 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$DetailedState;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.CallStaticObjectMethod(android.net.NetworkInfo.DetailedState.staticClass, global::android.net.NetworkInfo.DetailedState._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.NetworkInfo.DetailedState;
			}
			internal static global::MonoJavaBridge.FieldId _AUTHENTICATING2974;
			public static global::android.net.NetworkInfo.DetailedState AUTHENTICATING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _AUTHENTICATING2974)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTED2975;
			public static global::android.net.NetworkInfo.DetailedState CONNECTED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _CONNECTED2975)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTING2976;
			public static global::android.net.NetworkInfo.DetailedState CONNECTING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _CONNECTING2976)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTED2977;
			public static global::android.net.NetworkInfo.DetailedState DISCONNECTED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _DISCONNECTED2977)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTING2978;
			public static global::android.net.NetworkInfo.DetailedState DISCONNECTING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _DISCONNECTING2978)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _FAILED2979;
			public static global::android.net.NetworkInfo.DetailedState FAILED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _FAILED2979)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _IDLE2980;
			public static global::android.net.NetworkInfo.DetailedState IDLE
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _IDLE2980)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _OBTAINING_IPADDR2981;
			public static global::android.net.NetworkInfo.DetailedState OBTAINING_IPADDR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _OBTAINING_IPADDR2981)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SCANNING2982;
			public static global::android.net.NetworkInfo.DetailedState SCANNING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _SCANNING2982)) as android.net.NetworkInfo.DetailedState;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUSPENDED2983;
			public static global::android.net.NetworkInfo.DetailedState SUSPENDED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.DetailedState>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.DetailedState.staticClass, _SUSPENDED2983)) as android.net.NetworkInfo.DetailedState;
				}
			}
			static DetailedState()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.NetworkInfo.DetailedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/NetworkInfo$DetailedState"));
				global::android.net.NetworkInfo.DetailedState._AUTHENTICATING2974 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "AUTHENTICATING", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._CONNECTED2975 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "CONNECTED", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._CONNECTING2976 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "CONNECTING", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._DISCONNECTED2977 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "DISCONNECTED", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._DISCONNECTING2978 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "DISCONNECTING", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._FAILED2979 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "FAILED", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._IDLE2980 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "IDLE", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._OBTAINING_IPADDR2981 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "OBTAINING_IPADDR", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._SCANNING2982 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "SCANNING", "Landroid/net/NetworkInfo$DetailedState;");
				global::android.net.NetworkInfo.DetailedState._SUSPENDED2983 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "SUSPENDED", "Landroid/net/NetworkInfo$DetailedState;");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class State : java.lang.Enum
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal State(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public static global::android.net.NetworkInfo.State[] values()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.NetworkInfo.State._m0.native == global::System.IntPtr.Zero)
					global::android.net.NetworkInfo.State._m0 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "values", "()[Landroid/net/NetworkInfo/State;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.NetworkInfo.State>(@__env.CallStaticObjectMethod(android.net.NetworkInfo.State.staticClass, global::android.net.NetworkInfo.State._m0)) as android.net.NetworkInfo.State[];
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public static global::android.net.NetworkInfo.State valueOf(java.lang.String arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.net.NetworkInfo.State._m1.native == global::System.IntPtr.Zero)
					global::android.net.NetworkInfo.State._m1 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$State;");
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.CallStaticObjectMethod(android.net.NetworkInfo.State.staticClass, global::android.net.NetworkInfo.State._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.NetworkInfo.State;
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTED2984;
			public static global::android.net.NetworkInfo.State CONNECTED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _CONNECTED2984)) as android.net.NetworkInfo.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTING2985;
			public static global::android.net.NetworkInfo.State CONNECTING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _CONNECTING2985)) as android.net.NetworkInfo.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTED2986;
			public static global::android.net.NetworkInfo.State DISCONNECTED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _DISCONNECTED2986)) as android.net.NetworkInfo.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTING2987;
			public static global::android.net.NetworkInfo.State DISCONNECTING
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _DISCONNECTING2987)) as android.net.NetworkInfo.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUSPENDED2988;
			public static global::android.net.NetworkInfo.State SUSPENDED
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _SUSPENDED2988)) as android.net.NetworkInfo.State;
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNKNOWN2989;
			public static global::android.net.NetworkInfo.State UNKNOWN
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<android.net.NetworkInfo.State>(@__env.GetStaticObjectField(global::android.net.NetworkInfo.State.staticClass, _UNKNOWN2989)) as android.net.NetworkInfo.State;
				}
			}
			static State()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.NetworkInfo.State.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/NetworkInfo$State"));
				global::android.net.NetworkInfo.State._CONNECTED2984 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "CONNECTED", "Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._CONNECTING2985 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "CONNECTING", "Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._DISCONNECTED2986 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "DISCONNECTED", "Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._DISCONNECTING2987 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "DISCONNECTING", "Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._SUSPENDED2988 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "SUSPENDED", "Landroid/net/NetworkInfo$State;");
				global::android.net.NetworkInfo.State._UNKNOWN2989 = @__env.GetStaticFieldIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "UNKNOWN", "Landroid/net/NetworkInfo$State;");
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public override global::java.lang.String toString()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.NetworkInfo.staticClass, "toString", "()Ljava/lang/String;", ref global::android.net.NetworkInfo._m0) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual global::android.net.NetworkInfo.State getState()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.NetworkInfo.State>(this, global::android.net.NetworkInfo.staticClass, "getState", "()Landroid/net/NetworkInfo$State;", ref global::android.net.NetworkInfo._m1) as android.net.NetworkInfo.State;
		}
		public new int Type
		{
			get
			{
				return getType();
			}
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual int getType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.NetworkInfo.staticClass, "getType", "()I", ref global::android.net.NetworkInfo._m2);
		}
		public new global::java.lang.String TypeName
		{
			get
			{
				return getTypeName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual global::java.lang.String getTypeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.NetworkInfo.staticClass, "getTypeName", "()Ljava/lang/String;", ref global::android.net.NetworkInfo._m3) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isAvailable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.NetworkInfo.staticClass, "isAvailable", "()Z", ref global::android.net.NetworkInfo._m4);
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.net.NetworkInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.net.NetworkInfo._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual int describeContents()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.NetworkInfo.staticClass, "describeContents", "()I", ref global::android.net.NetworkInfo._m6);
		}
		public new global::java.lang.String Reason
		{
			get
			{
				return getReason();
			}
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::java.lang.String getReason()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.NetworkInfo.staticClass, "getReason", "()Ljava/lang/String;", ref global::android.net.NetworkInfo._m7) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual bool isConnected()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.NetworkInfo.staticClass, "isConnected", "()Z", ref global::android.net.NetworkInfo._m8);
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual bool isFailover()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.NetworkInfo.staticClass, "isFailover", "()Z", ref global::android.net.NetworkInfo._m9);
		}
		public new int Subtype
		{
			get
			{
				return getSubtype();
			}
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public virtual int getSubtype()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.net.NetworkInfo.staticClass, "getSubtype", "()I", ref global::android.net.NetworkInfo._m10);
		}
		public new global::java.lang.String SubtypeName
		{
			get
			{
				return getSubtypeName();
			}
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual global::java.lang.String getSubtypeName()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.NetworkInfo.staticClass, "getSubtypeName", "()Ljava/lang/String;", ref global::android.net.NetworkInfo._m11) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual bool isConnectedOrConnecting()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.NetworkInfo.staticClass, "isConnectedOrConnecting", "()Z", ref global::android.net.NetworkInfo._m12);
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual bool isRoaming()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.net.NetworkInfo.staticClass, "isRoaming", "()Z", ref global::android.net.NetworkInfo._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual global::android.net.NetworkInfo.DetailedState getDetailedState()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<android.net.NetworkInfo.DetailedState>(this, global::android.net.NetworkInfo.staticClass, "getDetailedState", "()Landroid/net/NetworkInfo$DetailedState;", ref global::android.net.NetworkInfo._m14) as android.net.NetworkInfo.DetailedState;
		}
		public new global::java.lang.String ExtraInfo
		{
			get
			{
				return getExtraInfo();
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual global::java.lang.String getExtraInfo()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.net.NetworkInfo.staticClass, "getExtraInfo", "()Ljava/lang/String;", ref global::android.net.NetworkInfo._m15) as java.lang.String;
		}
		static NetworkInfo()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.NetworkInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/NetworkInfo"));
		}
	}
}
