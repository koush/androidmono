namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class NetworkInfo : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static NetworkInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.NetworkInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.net.NetworkInfo(@__env); 
			} 
		} 
		protected NetworkInfo(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class DetailedState : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static DetailedState() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.NetworkInfo.DetailedState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.NetworkInfo.DetailedState(@__env); 
				} 
			} 
			internal DetailedState(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf4687; 
			public static global::android.net.NetworkInfo.DetailedState valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo.DetailedState>(@__env, @__env.CallStaticObjectMethodPtr(android.net.NetworkInfo.DetailedState.staticClass, global::android.net.NetworkInfo.DetailedState._valueOf4687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values4688; 
			public static global::android.net.NetworkInfo.DetailedState[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.net.NetworkInfo.DetailedState.staticClass, global::android.net.NetworkInfo.DetailedState._values4688)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _AUTHENTICATING4689; 
			public static global::android.net.NetworkInfo.DetailedState AUTHENTICATING
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONNECTED4690; 
			public static global::android.net.NetworkInfo.DetailedState CONNECTED
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONNECTING4691; 
			public static global::android.net.NetworkInfo.DetailedState CONNECTING
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DISCONNECTED4692; 
			public static global::android.net.NetworkInfo.DetailedState DISCONNECTED
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DISCONNECTING4693; 
			public static global::android.net.NetworkInfo.DetailedState DISCONNECTING
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FAILED4694; 
			public static global::android.net.NetworkInfo.DetailedState FAILED
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _IDLE4695; 
			public static global::android.net.NetworkInfo.DetailedState IDLE
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _OBTAINING_IPADDR4696; 
			public static global::android.net.NetworkInfo.DetailedState OBTAINING_IPADDR
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SCANNING4697; 
			public static global::android.net.NetworkInfo.DetailedState SCANNING
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SUSPENDED4698; 
			public static global::android.net.NetworkInfo.DetailedState SUSPENDED
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.DetailedState); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.NetworkInfo.DetailedState.staticClass = @__class; 
				global::android.net.NetworkInfo.DetailedState._valueOf4687 = @__env.GetStaticMethodID(global::android.net.NetworkInfo.DetailedState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$DetailedState;"); 
				global::android.net.NetworkInfo.DetailedState._values4688 = @__env.GetStaticMethodID(global::android.net.NetworkInfo.DetailedState.staticClass, "values", "()[Landroid/net/NetworkInfo/DetailedState;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class State : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static State() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.net.NetworkInfo.State), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.net.NetworkInfo.State(@__env); 
				} 
			} 
			internal State(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _valueOf4699; 
			public static global::android.net.NetworkInfo.State valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo.State>(@__env, @__env.CallStaticObjectMethodPtr(android.net.NetworkInfo.State.staticClass, global::android.net.NetworkInfo.State._valueOf4699, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values4700; 
			public static global::android.net.NetworkInfo.State[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.net.NetworkInfo.State.staticClass, global::android.net.NetworkInfo.State._values4700)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONNECTED4701; 
			public static global::android.net.NetworkInfo.State CONNECTED
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.State); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONNECTING4702; 
			public static global::android.net.NetworkInfo.State CONNECTING
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.State); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DISCONNECTED4703; 
			public static global::android.net.NetworkInfo.State DISCONNECTED
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.State); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DISCONNECTING4704; 
			public static global::android.net.NetworkInfo.State DISCONNECTING
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.State); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SUSPENDED4705; 
			public static global::android.net.NetworkInfo.State SUSPENDED
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.State); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _UNKNOWN4706; 
			public static global::android.net.NetworkInfo.State UNKNOWN
			{ 
				get 
				{ 
					return default(global::android.net.NetworkInfo.State); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.NetworkInfo.State.staticClass = @__class; 
				global::android.net.NetworkInfo.State._valueOf4699 = @__env.GetStaticMethodID(global::android.net.NetworkInfo.State.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$State;"); 
				global::android.net.NetworkInfo.State._values4700 = @__env.GetStaticMethodID(global::android.net.NetworkInfo.State.staticClass, "values", "()[Landroid/net/NetworkInfo/State;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString4707; 
		public override global::java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.NetworkInfo._toString4707)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._toString4707)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getState4708; 
		public virtual global::android.net.NetworkInfo.State getState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo.State>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.NetworkInfo._getState4708)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo.State>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getState4708)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getType4709; 
		public virtual int getType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.NetworkInfo._getType4709); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getType4709); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTypeName4710; 
		public virtual global::java.lang.String getTypeName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.NetworkInfo._getTypeName4710)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getTypeName4710)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAvailable4711; 
		public virtual bool isAvailable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.NetworkInfo._isAvailable4711); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isAvailable4711); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4712; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.net.NetworkInfo._writeToParcel4712, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._writeToParcel4712, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4713; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.NetworkInfo._describeContents4713); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._describeContents4713); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReason4714; 
		public virtual global::java.lang.String getReason() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.NetworkInfo._getReason4714)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getReason4714)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isConnected4715; 
		public virtual bool isConnected() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.NetworkInfo._isConnected4715); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isConnected4715); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFailover4716; 
		public virtual bool isFailover() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.NetworkInfo._isFailover4716); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isFailover4716); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubtype4717; 
		public virtual int getSubtype() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.net.NetworkInfo._getSubtype4717); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getSubtype4717); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubtypeName4718; 
		public virtual global::java.lang.String getSubtypeName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.NetworkInfo._getSubtypeName4718)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getSubtypeName4718)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isConnectedOrConnecting4719; 
		public virtual bool isConnectedOrConnecting() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.NetworkInfo._isConnectedOrConnecting4719); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isConnectedOrConnecting4719); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isRoaming4720; 
		public virtual bool isRoaming() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.net.NetworkInfo._isRoaming4720); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._isRoaming4720); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDetailedState4721; 
		public virtual global::android.net.NetworkInfo.DetailedState getDetailedState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo.DetailedState>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.NetworkInfo._getDetailedState4721)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo.DetailedState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getDetailedState4721)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtraInfo4722; 
		public virtual global::java.lang.String getExtraInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.net.NetworkInfo._getExtraInfo4722)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.net.NetworkInfo.staticClass, global::android.net.NetworkInfo._getExtraInfo4722)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.NetworkInfo.staticClass = @__class; 
			global::android.net.NetworkInfo._toString4707 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.NetworkInfo._getState4708 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getState", "()Landroid/net/NetworkInfo$State;"); 
			global::android.net.NetworkInfo._getType4709 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getType", "()I"); 
			global::android.net.NetworkInfo._getTypeName4710 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getTypeName", "()Ljava/lang/String;"); 
			global::android.net.NetworkInfo._isAvailable4711 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "isAvailable", "()Z"); 
			global::android.net.NetworkInfo._writeToParcel4712 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.net.NetworkInfo._describeContents4713 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "describeContents", "()I"); 
			global::android.net.NetworkInfo._getReason4714 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getReason", "()Ljava/lang/String;"); 
			global::android.net.NetworkInfo._isConnected4715 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "isConnected", "()Z"); 
			global::android.net.NetworkInfo._isFailover4716 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "isFailover", "()Z"); 
			global::android.net.NetworkInfo._getSubtype4717 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getSubtype", "()I"); 
			global::android.net.NetworkInfo._getSubtypeName4718 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getSubtypeName", "()Ljava/lang/String;"); 
			global::android.net.NetworkInfo._isConnectedOrConnecting4719 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "isConnectedOrConnecting", "()Z"); 
			global::android.net.NetworkInfo._isRoaming4720 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "isRoaming", "()Z"); 
			global::android.net.NetworkInfo._getDetailedState4721 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getDetailedState", "()Landroid/net/NetworkInfo$DetailedState;"); 
			global::android.net.NetworkInfo._getExtraInfo4722 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getExtraInfo", "()Ljava/lang/String;"); 
		} 
	} 
} 
