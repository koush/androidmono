namespace android.bluetooth 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class BluetoothClass : java.lang.Object, android.os.Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static BluetoothClass() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.bluetooth.BluetoothClass), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.bluetooth.BluetoothClass(@__env); 
			} 
		} 
		internal BluetoothClass(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public class Device : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Device() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.bluetooth.BluetoothClass.Device), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.bluetooth.BluetoothClass.Device(@__env); 
				} 
			} 
			protected Device(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
			public class Major : java.lang.Object
			{ 
				internal static global::java.lang.Class staticClass; 
				static Major() 
				{ 
					global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.bluetooth.BluetoothClass.Device.Major), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
				} 
				private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
				{ 
					public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
					{ 
						return new global::android.bluetooth.BluetoothClass.Device.Major(@__env); 
					} 
				} 
				protected Major(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
				{ 
				} 
				internal static global::net.sf.jni4net.jni.MethodId _Major878; 
				public Major()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
				{ 
					global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
					@__env.NewObject(android.bluetooth.BluetoothClass.Device.Major.staticClass, _Major878, this); 
				} 
				public static int MISC
				{ 
					get 
					{ 
						return 0; 
					} 
				} 
				public static int COMPUTER
				{ 
					get 
					{ 
						return 256; 
					} 
				} 
				public static int PHONE
				{ 
					get 
					{ 
						return 512; 
					} 
				} 
				public static int NETWORKING
				{ 
					get 
					{ 
						return 768; 
					} 
				} 
				public static int AUDIO_VIDEO
				{ 
					get 
					{ 
						return 1024; 
					} 
				} 
				public static int PERIPHERAL
				{ 
					get 
					{ 
						return 1280; 
					} 
				} 
				public static int IMAGING
				{ 
					get 
					{ 
						return 1536; 
					} 
				} 
				public static int WEARABLE
				{ 
					get 
					{ 
						return 1792; 
					} 
				} 
				public static int TOY
				{ 
					get 
					{ 
						return 2048; 
					} 
				} 
				public static int HEALTH
				{ 
					get 
					{ 
						return 2304; 
					} 
				} 
				public static int UNCATEGORIZED
				{ 
					get 
					{ 
						return 7936; 
					} 
				} 
				private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
				{ 
					global::android.bluetooth.BluetoothClass.Device.Major.staticClass = @__class; 
					global::android.bluetooth.BluetoothClass.Device.Major._Major878 = @__env.GetMethodID(global::android.bluetooth.BluetoothClass.Device.Major.staticClass, "<init>", "()V"); 
				} 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Device879; 
			public Device()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.bluetooth.BluetoothClass.Device.staticClass, _Device879, this); 
			} 
			public static int COMPUTER_UNCATEGORIZED
			{ 
				get 
				{ 
					return 256; 
				} 
			} 
			public static int COMPUTER_DESKTOP
			{ 
				get 
				{ 
					return 260; 
				} 
			} 
			public static int COMPUTER_SERVER
			{ 
				get 
				{ 
					return 264; 
				} 
			} 
			public static int COMPUTER_LAPTOP
			{ 
				get 
				{ 
					return 268; 
				} 
			} 
			public static int COMPUTER_HANDHELD_PC_PDA
			{ 
				get 
				{ 
					return 272; 
				} 
			} 
			public static int COMPUTER_PALM_SIZE_PC_PDA
			{ 
				get 
				{ 
					return 276; 
				} 
			} 
			public static int COMPUTER_WEARABLE
			{ 
				get 
				{ 
					return 280; 
				} 
			} 
			public static int PHONE_UNCATEGORIZED
			{ 
				get 
				{ 
					return 512; 
				} 
			} 
			public static int PHONE_CELLULAR
			{ 
				get 
				{ 
					return 516; 
				} 
			} 
			public static int PHONE_CORDLESS
			{ 
				get 
				{ 
					return 520; 
				} 
			} 
			public static int PHONE_SMART
			{ 
				get 
				{ 
					return 524; 
				} 
			} 
			public static int PHONE_MODEM_OR_GATEWAY
			{ 
				get 
				{ 
					return 528; 
				} 
			} 
			public static int PHONE_ISDN
			{ 
				get 
				{ 
					return 532; 
				} 
			} 
			public static int AUDIO_VIDEO_UNCATEGORIZED
			{ 
				get 
				{ 
					return 1024; 
				} 
			} 
			public static int AUDIO_VIDEO_WEARABLE_HEADSET
			{ 
				get 
				{ 
					return 1028; 
				} 
			} 
			public static int AUDIO_VIDEO_HANDSFREE
			{ 
				get 
				{ 
					return 1032; 
				} 
			} 
			public static int AUDIO_VIDEO_MICROPHONE
			{ 
				get 
				{ 
					return 1040; 
				} 
			} 
			public static int AUDIO_VIDEO_LOUDSPEAKER
			{ 
				get 
				{ 
					return 1044; 
				} 
			} 
			public static int AUDIO_VIDEO_HEADPHONES
			{ 
				get 
				{ 
					return 1048; 
				} 
			} 
			public static int AUDIO_VIDEO_PORTABLE_AUDIO
			{ 
				get 
				{ 
					return 1052; 
				} 
			} 
			public static int AUDIO_VIDEO_CAR_AUDIO
			{ 
				get 
				{ 
					return 1056; 
				} 
			} 
			public static int AUDIO_VIDEO_SET_TOP_BOX
			{ 
				get 
				{ 
					return 1060; 
				} 
			} 
			public static int AUDIO_VIDEO_HIFI_AUDIO
			{ 
				get 
				{ 
					return 1064; 
				} 
			} 
			public static int AUDIO_VIDEO_VCR
			{ 
				get 
				{ 
					return 1068; 
				} 
			} 
			public static int AUDIO_VIDEO_VIDEO_CAMERA
			{ 
				get 
				{ 
					return 1072; 
				} 
			} 
			public static int AUDIO_VIDEO_CAMCORDER
			{ 
				get 
				{ 
					return 1076; 
				} 
			} 
			public static int AUDIO_VIDEO_VIDEO_MONITOR
			{ 
				get 
				{ 
					return 1080; 
				} 
			} 
			public static int AUDIO_VIDEO_VIDEO_DISPLAY_AND_LOUDSPEAKER
			{ 
				get 
				{ 
					return 1084; 
				} 
			} 
			public static int AUDIO_VIDEO_VIDEO_CONFERENCING
			{ 
				get 
				{ 
					return 1088; 
				} 
			} 
			public static int AUDIO_VIDEO_VIDEO_GAMING_TOY
			{ 
				get 
				{ 
					return 1096; 
				} 
			} 
			public static int WEARABLE_UNCATEGORIZED
			{ 
				get 
				{ 
					return 1792; 
				} 
			} 
			public static int WEARABLE_WRIST_WATCH
			{ 
				get 
				{ 
					return 1796; 
				} 
			} 
			public static int WEARABLE_PAGER
			{ 
				get 
				{ 
					return 1800; 
				} 
			} 
			public static int WEARABLE_JACKET
			{ 
				get 
				{ 
					return 1804; 
				} 
			} 
			public static int WEARABLE_HELMET
			{ 
				get 
				{ 
					return 1808; 
				} 
			} 
			public static int WEARABLE_GLASSES
			{ 
				get 
				{ 
					return 1812; 
				} 
			} 
			public static int TOY_UNCATEGORIZED
			{ 
				get 
				{ 
					return 2048; 
				} 
			} 
			public static int TOY_ROBOT
			{ 
				get 
				{ 
					return 2052; 
				} 
			} 
			public static int TOY_VEHICLE
			{ 
				get 
				{ 
					return 2056; 
				} 
			} 
			public static int TOY_DOLL_ACTION_FIGURE
			{ 
				get 
				{ 
					return 2060; 
				} 
			} 
			public static int TOY_CONTROLLER
			{ 
				get 
				{ 
					return 2064; 
				} 
			} 
			public static int TOY_GAME
			{ 
				get 
				{ 
					return 2068; 
				} 
			} 
			public static int HEALTH_UNCATEGORIZED
			{ 
				get 
				{ 
					return 2304; 
				} 
			} 
			public static int HEALTH_BLOOD_PRESSURE
			{ 
				get 
				{ 
					return 2308; 
				} 
			} 
			public static int HEALTH_THERMOMETER
			{ 
				get 
				{ 
					return 2312; 
				} 
			} 
			public static int HEALTH_WEIGHING
			{ 
				get 
				{ 
					return 2316; 
				} 
			} 
			public static int HEALTH_GLUCOSE
			{ 
				get 
				{ 
					return 2320; 
				} 
			} 
			public static int HEALTH_PULSE_OXIMETER
			{ 
				get 
				{ 
					return 2324; 
				} 
			} 
			public static int HEALTH_PULSE_RATE
			{ 
				get 
				{ 
					return 2328; 
				} 
			} 
			public static int HEALTH_DATA_DISPLAY
			{ 
				get 
				{ 
					return 2332; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.bluetooth.BluetoothClass.Device.staticClass = @__class; 
				global::android.bluetooth.BluetoothClass.Device._Device879 = @__env.GetMethodID(global::android.bluetooth.BluetoothClass.Device.staticClass, "<init>", "()V"); 
			} 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		public sealed class Service : java.lang.Object
		{ 
			internal static global::java.lang.Class staticClass; 
			static Service() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.bluetooth.BluetoothClass.Service), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.bluetooth.BluetoothClass.Service(@__env); 
				} 
			} 
			internal Service(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _Service880; 
			public Service()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.bluetooth.BluetoothClass.Service.staticClass, _Service880, this); 
			} 
			public static int LIMITED_DISCOVERABILITY
			{ 
				get 
				{ 
					return 8192; 
				} 
			} 
			public static int POSITIONING
			{ 
				get 
				{ 
					return 65536; 
				} 
			} 
			public static int NETWORKING
			{ 
				get 
				{ 
					return 131072; 
				} 
			} 
			public static int RENDER
			{ 
				get 
				{ 
					return 262144; 
				} 
			} 
			public static int CAPTURE
			{ 
				get 
				{ 
					return 524288; 
				} 
			} 
			public static int OBJECT_TRANSFER
			{ 
				get 
				{ 
					return 1048576; 
				} 
			} 
			public static int AUDIO
			{ 
				get 
				{ 
					return 2097152; 
				} 
			} 
			public static int TELEPHONY
			{ 
				get 
				{ 
					return 4194304; 
				} 
			} 
			public static int INFORMATION
			{ 
				get 
				{ 
					return 8388608; 
				} 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.bluetooth.BluetoothClass.Service.staticClass = @__class; 
				global::android.bluetooth.BluetoothClass.Service._Service880 = @__env.GetMethodID(global::android.bluetooth.BluetoothClass.Service.staticClass, "<init>", "()V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode881; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothClass)) 
				return @__env.CallIntMethod(this, _hashCode881); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.bluetooth.BluetoothClass.staticClass, _hashCode881); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals882; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothClass)) 
				return @__env.CallBooleanMethod(this, _equals882, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.bluetooth.BluetoothClass.staticClass, _equals882, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _toString883; 
		public sealed override java.lang.String toString() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothClass)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _toString883)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.bluetooth.BluetoothClass.staticClass, _toString883)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel884; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothClass)) 
				@__env.CallVoidMethod(this, _writeToParcel884, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.bluetooth.BluetoothClass.staticClass, _writeToParcel884, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents885; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothClass)) 
				return @__env.CallIntMethod(this, _describeContents885); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.bluetooth.BluetoothClass.staticClass, _describeContents885); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hasService886; 
		public bool hasService(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothClass)) 
				return @__env.CallBooleanMethod(this, _hasService886, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.bluetooth.BluetoothClass.staticClass, _hasService886, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getMajorDeviceClass887; 
		public int getMajorDeviceClass() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothClass)) 
				return @__env.CallIntMethod(this, _getMajorDeviceClass887); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.bluetooth.BluetoothClass.staticClass, _getMajorDeviceClass887); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDeviceClass888; 
		public int getDeviceClass() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.bluetooth.BluetoothClass)) 
				return @__env.CallIntMethod(this, _getDeviceClass888); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.bluetooth.BluetoothClass.staticClass, _getDeviceClass888); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR889; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.bluetooth.BluetoothClass.staticClass = @__class; 
			global::android.bluetooth.BluetoothClass._hashCode881 = @__env.GetMethodID(global::android.bluetooth.BluetoothClass.staticClass, "hashCode", "()I"); 
			global::android.bluetooth.BluetoothClass._equals882 = @__env.GetMethodID(global::android.bluetooth.BluetoothClass.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.bluetooth.BluetoothClass._toString883 = @__env.GetMethodID(global::android.bluetooth.BluetoothClass.staticClass, "toString", "()Ljava/lang/String;"); 
			global::android.bluetooth.BluetoothClass._writeToParcel884 = @__env.GetMethodID(global::android.bluetooth.BluetoothClass.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.bluetooth.BluetoothClass._describeContents885 = @__env.GetMethodID(global::android.bluetooth.BluetoothClass.staticClass, "describeContents", "()I"); 
			global::android.bluetooth.BluetoothClass._hasService886 = @__env.GetMethodID(global::android.bluetooth.BluetoothClass.staticClass, "hasService", "(I)Z"); 
			global::android.bluetooth.BluetoothClass._getMajorDeviceClass887 = @__env.GetMethodID(global::android.bluetooth.BluetoothClass.staticClass, "getMajorDeviceClass", "()I"); 
			global::android.bluetooth.BluetoothClass._getDeviceClass888 = @__env.GetMethodID(global::android.bluetooth.BluetoothClass.staticClass, "getDeviceClass", "()I"); 
		} 
	} 
} 
