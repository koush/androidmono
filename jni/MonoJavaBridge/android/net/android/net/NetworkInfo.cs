namespace android.net 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class NetworkInfo : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static NetworkInfo() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.NetworkInfo), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.NetworkInfo.DetailedState), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf4439; 
			public static android.net.NetworkInfo.DetailedState valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo.DetailedState>(@__env, @__env.CallStaticObjectMethodPtr(android.net.NetworkInfo.DetailedState.staticClass, _valueOf4439, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values4440; 
			public static android.net.NetworkInfo.DetailedState[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.net.NetworkInfo.DetailedState.staticClass, _values4440)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _AUTHENTICATING4441; 
			public static android.net.NetworkInfo.DetailedState AUTHENTICATING
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONNECTED4442; 
			public static android.net.NetworkInfo.DetailedState CONNECTED
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONNECTING4443; 
			public static android.net.NetworkInfo.DetailedState CONNECTING
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DISCONNECTED4444; 
			public static android.net.NetworkInfo.DetailedState DISCONNECTED
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DISCONNECTING4445; 
			public static android.net.NetworkInfo.DetailedState DISCONNECTING
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _FAILED4446; 
			public static android.net.NetworkInfo.DetailedState FAILED
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _IDLE4447; 
			public static android.net.NetworkInfo.DetailedState IDLE
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _OBTAINING_IPADDR4448; 
			public static android.net.NetworkInfo.DetailedState OBTAINING_IPADDR
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SCANNING4449; 
			public static android.net.NetworkInfo.DetailedState SCANNING
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.DetailedState); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SUSPENDED4450; 
			public static android.net.NetworkInfo.DetailedState SUSPENDED
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.DetailedState); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.NetworkInfo.DetailedState.staticClass = @__class; 
				global::android.net.NetworkInfo.DetailedState._valueOf4439 = @__env.GetStaticMethodID(global::android.net.NetworkInfo.DetailedState.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$DetailedState;"); 
				global::android.net.NetworkInfo.DetailedState._values4440 = @__env.GetStaticMethodID(global::android.net.NetworkInfo.DetailedState.staticClass, "values", "()[Landroid/net/NetworkInfo/DetailedState;"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class State : java.lang.Enum
		{ 
			internal new static global::java.lang.Class staticClass; 
			static State() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.net.NetworkInfo.State), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
			internal static global::net.sf.jni4net.jni.MethodId _valueOf4451; 
			public static android.net.NetworkInfo.State valueOf(java.lang.String arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo.State>(@__env, @__env.CallStaticObjectMethodPtr(android.net.NetworkInfo.State.staticClass, _valueOf4451, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _values4452; 
			public static android.net.NetworkInfo.State[] values() 
			{ 
				return null;//(@__env, @__env.CallStaticObjectMethodPtr(android.net.NetworkInfo.State.staticClass, _values4452)); 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONNECTED4453; 
			public static android.net.NetworkInfo.State CONNECTED
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.State); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _CONNECTING4454; 
			public static android.net.NetworkInfo.State CONNECTING
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.State); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DISCONNECTED4455; 
			public static android.net.NetworkInfo.State DISCONNECTED
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.State); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _DISCONNECTING4456; 
			public static android.net.NetworkInfo.State DISCONNECTING
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.State); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _SUSPENDED4457; 
			public static android.net.NetworkInfo.State SUSPENDED
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.State); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.FieldId _UNKNOWN4458; 
			public static android.net.NetworkInfo.State UNKNOWN
			{ 
				get 
				{ 
					return default(android.net.NetworkInfo.State); 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.net.NetworkInfo.State.staticClass = @__class; 
				global::android.net.NetworkInfo.State._valueOf4451 = @__env.GetStaticMethodID(global::android.net.NetworkInfo.State.staticClass, "valueOf", "(Ljava/lang/String;)Landroid/net/NetworkInfo$State;"); 
				global::android.net.NetworkInfo.State._values4452 = @__env.GetStaticMethodID(global::android.net.NetworkInfo.State.staticClass, "values", "()[Landroid/net/NetworkInfo/State;"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString4459; 
		public override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString4459)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.NetworkInfo.staticClass, _toString4459)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getState4460; 
		public virtual android.net.NetworkInfo.State getState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo.State>(@__env, @__env.CallObjectMethodPtr(this, _getState4460)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo.State>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.NetworkInfo.staticClass, _getState4460)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getType4461; 
		public virtual int getType() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				return @__env.CallIntMethod(this, _getType4461); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.NetworkInfo.staticClass, _getType4461); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getTypeName4462; 
		public virtual java.lang.String getTypeName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getTypeName4462)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.NetworkInfo.staticClass, _getTypeName4462)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAvailable4463; 
		public virtual bool isAvailable() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				return @__env.CallBooleanMethod(this, _isAvailable4463); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.NetworkInfo.staticClass, _isAvailable4463); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel4464; 
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				@__env.CallVoidMethod(this, _writeToParcel4464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.net.NetworkInfo.staticClass, _writeToParcel4464, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents4465; 
		public virtual int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				return @__env.CallIntMethod(this, _describeContents4465); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.NetworkInfo.staticClass, _describeContents4465); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getReason4466; 
		public virtual java.lang.String getReason() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getReason4466)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.NetworkInfo.staticClass, _getReason4466)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isConnected4467; 
		public virtual bool isConnected() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				return @__env.CallBooleanMethod(this, _isConnected4467); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.NetworkInfo.staticClass, _isConnected4467); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFailover4468; 
		public virtual bool isFailover() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				return @__env.CallBooleanMethod(this, _isFailover4468); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.NetworkInfo.staticClass, _isFailover4468); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubtype4469; 
		public virtual int getSubtype() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				return @__env.CallIntMethod(this, _getSubtype4469); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.net.NetworkInfo.staticClass, _getSubtype4469); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getSubtypeName4470; 
		public virtual java.lang.String getSubtypeName() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getSubtypeName4470)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.NetworkInfo.staticClass, _getSubtypeName4470)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isConnectedOrConnecting4471; 
		public virtual bool isConnectedOrConnecting() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				return @__env.CallBooleanMethod(this, _isConnectedOrConnecting4471); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.NetworkInfo.staticClass, _isConnectedOrConnecting4471); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isRoaming4472; 
		public virtual bool isRoaming() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				return @__env.CallBooleanMethod(this, _isRoaming4472); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.net.NetworkInfo.staticClass, _isRoaming4472); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDetailedState4473; 
		public virtual android.net.NetworkInfo.DetailedState getDetailedState() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo.DetailedState>(@__env, @__env.CallObjectMethodPtr(this, _getDetailedState4473)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.net.NetworkInfo.DetailedState>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.NetworkInfo.staticClass, _getDetailedState4473)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtraInfo4474; 
		public virtual java.lang.String getExtraInfo() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.net.NetworkInfo)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getExtraInfo4474)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.net.NetworkInfo.staticClass, _getExtraInfo4474)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.net.NetworkInfo.staticClass = @__class; 
			global::android.net.NetworkInfo._toString4459 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.net.NetworkInfo._getState4460 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getState", "()Landroid/net/NetworkInfo$State;"); 
			global::android.net.NetworkInfo._getType4461 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getType", "()I"); 
			global::android.net.NetworkInfo._getTypeName4462 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getTypeName", "()Ljava/lang/String;"); 
			global::android.net.NetworkInfo._isAvailable4463 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "isAvailable", "()Z"); 
			global::android.net.NetworkInfo._writeToParcel4464 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.net.NetworkInfo._describeContents4465 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "describeContents", "()I"); 
			global::android.net.NetworkInfo._getReason4466 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getReason", "()Ljava/lang/String;"); 
			global::android.net.NetworkInfo._isConnected4467 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "isConnected", "()Z"); 
			global::android.net.NetworkInfo._isFailover4468 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "isFailover", "()Z"); 
			global::android.net.NetworkInfo._getSubtype4469 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getSubtype", "()I"); 
			global::android.net.NetworkInfo._getSubtypeName4470 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getSubtypeName", "()Ljava/lang/String;"); 
			global::android.net.NetworkInfo._isConnectedOrConnecting4471 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "isConnectedOrConnecting", "()Z"); 
			global::android.net.NetworkInfo._isRoaming4472 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "isRoaming", "()Z"); 
			global::android.net.NetworkInfo._getDetailedState4473 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getDetailedState", "()Landroid/net/NetworkInfo$DetailedState;"); 
			global::android.net.NetworkInfo._getExtraInfo4474 = @__env.GetMethodID(global::android.net.NetworkInfo.staticClass, "getExtraInfo", "()Ljava/lang/String;"); 
		} 
	} 
} 
