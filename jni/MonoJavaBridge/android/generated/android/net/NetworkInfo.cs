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
			internal static global::MonoJavaBridge.MethodId _values5198;
			public static global::android.net.NetworkInfo.DetailedState[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.NetworkInfo.DetailedState>(@__env.CallStaticObjectMethod(android.net.NetworkInfo.DetailedState.staticClass, global::android.net.NetworkInfo.DetailedState._values5198)) as android.net.NetworkInfo.DetailedState[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5199;
			public static global::android.net.NetworkInfo.DetailedState valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.NetworkInfo.DetailedState.staticClass, global::android.net.NetworkInfo.DetailedState._valueOf5199, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.NetworkInfo.DetailedState;
			}
			internal static global::MonoJavaBridge.FieldId _AUTHENTICATING5200;
			public static global::android.net.NetworkInfo.DetailedState AUTHENTICATING
			{
				get
				{
					return default(global::android.net.NetworkInfo.DetailedState);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTED5201;
			public static global::android.net.NetworkInfo.DetailedState CONNECTED
			{
				get
				{
					return default(global::android.net.NetworkInfo.DetailedState);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTING5202;
			public static global::android.net.NetworkInfo.DetailedState CONNECTING
			{
				get
				{
					return default(global::android.net.NetworkInfo.DetailedState);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTED5203;
			public static global::android.net.NetworkInfo.DetailedState DISCONNECTED
			{
				get
				{
					return default(global::android.net.NetworkInfo.DetailedState);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTING5204;
			public static global::android.net.NetworkInfo.DetailedState DISCONNECTING
			{
				get
				{
					return default(global::android.net.NetworkInfo.DetailedState);
				}
			}
			internal static global::MonoJavaBridge.FieldId _FAILED5205;
			public static global::android.net.NetworkInfo.DetailedState FAILED
			{
				get
				{
					return default(global::android.net.NetworkInfo.DetailedState);
				}
			}
			internal static global::MonoJavaBridge.FieldId _IDLE5206;
			public static global::android.net.NetworkInfo.DetailedState IDLE
			{
				get
				{
					return default(global::android.net.NetworkInfo.DetailedState);
				}
			}
			internal static global::MonoJavaBridge.FieldId _OBTAINING_IPADDR5207;
			public static global::android.net.NetworkInfo.DetailedState OBTAINING_IPADDR
			{
				get
				{
					return default(global::android.net.NetworkInfo.DetailedState);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SCANNING5208;
			public static global::android.net.NetworkInfo.DetailedState SCANNING
			{
				get
				{
					return default(global::android.net.NetworkInfo.DetailedState);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUSPENDED5209;
			public static global::android.net.NetworkInfo.DetailedState SUSPENDED
			{
				get
				{
					return default(global::android.net.NetworkInfo.DetailedState);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.NetworkInfo.DetailedState.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/NetworkInfo$DetailedState"));
				global::android.net.NetworkInfo.DetailedState._values5198 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "values", "()[Landroid/net/NetworkInfo/DetailedState;");
				global::android.net.NetworkInfo.DetailedState._valueOf5199 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.DetailedState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$DetailedState;");
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
			internal static global::MonoJavaBridge.MethodId _values5210;
			public static global::android.net.NetworkInfo.State[] values() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaArrayObject<android.net.NetworkInfo.State>(@__env.CallStaticObjectMethod(android.net.NetworkInfo.State.staticClass, global::android.net.NetworkInfo.State._values5210)) as android.net.NetworkInfo.State[];
			}
			internal static global::MonoJavaBridge.MethodId _valueOf5211;
			public static global::android.net.NetworkInfo.State valueOf(java.lang.String arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.net.NetworkInfo.State.staticClass, global::android.net.NetworkInfo.State._valueOf5211, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.net.NetworkInfo.State;
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTED5212;
			public static global::android.net.NetworkInfo.State CONNECTED
			{
				get
				{
					return default(global::android.net.NetworkInfo.State);
				}
			}
			internal static global::MonoJavaBridge.FieldId _CONNECTING5213;
			public static global::android.net.NetworkInfo.State CONNECTING
			{
				get
				{
					return default(global::android.net.NetworkInfo.State);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTED5214;
			public static global::android.net.NetworkInfo.State DISCONNECTED
			{
				get
				{
					return default(global::android.net.NetworkInfo.State);
				}
			}
			internal static global::MonoJavaBridge.FieldId _DISCONNECTING5215;
			public static global::android.net.NetworkInfo.State DISCONNECTING
			{
				get
				{
					return default(global::android.net.NetworkInfo.State);
				}
			}
			internal static global::MonoJavaBridge.FieldId _SUSPENDED5216;
			public static global::android.net.NetworkInfo.State SUSPENDED
			{
				get
				{
					return default(global::android.net.NetworkInfo.State);
				}
			}
			internal static global::MonoJavaBridge.FieldId _UNKNOWN5217;
			public static global::android.net.NetworkInfo.State UNKNOWN
			{
				get
				{
					return default(global::android.net.NetworkInfo.State);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.net.NetworkInfo.State.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/NetworkInfo$State"));
				global::android.net.NetworkInfo.State._values5210 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "values", "()[Landroid/net/NetworkInfo/State;");
				global::android.net.NetworkInfo.State._valueOf5211 = @__env.GetStaticMethodIDNoThrow(global::android.net.NetworkInfo.State.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$State;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _toString5218;
		public override global::java.lang.String toString() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._toString5218)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._toString5218)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _getState5219;
		public virtual global::android.net.NetworkInfo.State getState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getState5219)) as android.net.NetworkInfo.State;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getState5219)) as android.net.NetworkInfo.State;
		}
		internal static global::MonoJavaBridge.MethodId _getType5220;
		public virtual int getType() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.NetworkInfo._getType5220);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getType5220);
		}
		internal static global::MonoJavaBridge.MethodId _getTypeName5221;
		public virtual global::java.lang.String getTypeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getTypeName5221)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getTypeName5221)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isAvailable5222;
		public virtual bool isAvailable() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo._isAvailable5222);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isAvailable5222);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel5223;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.net.NetworkInfo._writeToParcel5223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._writeToParcel5223, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents5224;
		public virtual int describeContents() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.NetworkInfo._describeContents5224);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._describeContents5224);
		}
		internal static global::MonoJavaBridge.MethodId _getReason5225;
		public virtual global::java.lang.String getReason() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getReason5225)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getReason5225)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isConnected5226;
		public virtual bool isConnected() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo._isConnected5226);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isConnected5226);
		}
		internal static global::MonoJavaBridge.MethodId _isFailover5227;
		public virtual bool isFailover() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo._isFailover5227);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isFailover5227);
		}
		internal static global::MonoJavaBridge.MethodId _getSubtype5228;
		public virtual int getSubtype() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.net.NetworkInfo._getSubtype5228);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getSubtype5228);
		}
		internal static global::MonoJavaBridge.MethodId _getSubtypeName5229;
		public virtual global::java.lang.String getSubtypeName() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getSubtypeName5229)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getSubtypeName5229)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _isConnectedOrConnecting5230;
		public virtual bool isConnectedOrConnecting() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo._isConnectedOrConnecting5230);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isConnectedOrConnecting5230);
		}
		internal static global::MonoJavaBridge.MethodId _isRoaming5231;
		public virtual bool isRoaming() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo._isRoaming5231);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isRoaming5231);
		}
		internal static global::MonoJavaBridge.MethodId _getDetailedState5232;
		public virtual global::android.net.NetworkInfo.DetailedState getDetailedState() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getDetailedState5232)) as android.net.NetworkInfo.DetailedState;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getDetailedState5232)) as android.net.NetworkInfo.DetailedState;
		}
		internal static global::MonoJavaBridge.MethodId _getExtraInfo5233;
		public virtual global::java.lang.String getExtraInfo() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.net.NetworkInfo._getExtraInfo5233)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getExtraInfo5233)) as java.lang.String;
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.net.NetworkInfo.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/net/NetworkInfo"));
			global::android.net.NetworkInfo._toString5218 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "toString", "()Ljava/lang/String;");
			global::android.net.NetworkInfo._getState5219 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getState", "()Landroid/net/NetworkInfo$State;");
			global::android.net.NetworkInfo._getType5220 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getType", "()I");
			global::android.net.NetworkInfo._getTypeName5221 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getTypeName", "()Ljava/lang/String;");
			global::android.net.NetworkInfo._isAvailable5222 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "isAvailable", "()Z");
			global::android.net.NetworkInfo._writeToParcel5223 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.net.NetworkInfo._describeContents5224 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "describeContents", "()I");
			global::android.net.NetworkInfo._getReason5225 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getReason", "()Ljava/lang/String;");
			global::android.net.NetworkInfo._isConnected5226 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "isConnected", "()Z");
			global::android.net.NetworkInfo._isFailover5227 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "isFailover", "()Z");
			global::android.net.NetworkInfo._getSubtype5228 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getSubtype", "()I");
			global::android.net.NetworkInfo._getSubtypeName5229 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getSubtypeName", "()Ljava/lang/String;");
			global::android.net.NetworkInfo._isConnectedOrConnecting5230 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "isConnectedOrConnecting", "()Z");
			global::android.net.NetworkInfo._isRoaming5231 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "isRoaming", "()Z");
			global::android.net.NetworkInfo._getDetailedState5232 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getDetailedState", "()Landroid/net/NetworkInfo$DetailedState;");
			global::android.net.NetworkInfo._getExtraInfo5233 = @__env.GetMethodIDNoThrow(global::android.net.NetworkInfo.staticClass, "getExtraInfo", "()Ljava/lang/String;");
		}
	}
}
