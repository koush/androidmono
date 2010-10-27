namespace android.bluetooth
{
	[global::MonoJavaBridge.JavaClass()]
	public sealed partial class BluetoothClass : java.lang.Object, android.os.Parcelable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static BluetoothClass()
		{
			InitJNI();
		}
		internal BluetoothClass(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Device : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Device()
			{
				InitJNI();
			}
			protected Device(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			[global::MonoJavaBridge.JavaClass()]
			public partial class Major : java.lang.Object
			{
				internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
				static Major()
				{
					InitJNI();
				}
				protected Major(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
				{
				}
				internal static global::MonoJavaBridge.MethodId _Major2440;
				public Major() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.bluetooth.BluetoothClass.Device.Major.staticClass, global::android.bluetooth.BluetoothClass.Device.Major._Major2440);
					Init(@__env, handle);
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
				private static void InitJNI()
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					global::android.bluetooth.BluetoothClass.Device.Major.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/bluetooth/BluetoothClass$Device$Major"));
					global::android.bluetooth.BluetoothClass.Device.Major._Major2440 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothClass.Device.Major.staticClass, "<init>", "()V");
				}
			}
			internal static global::MonoJavaBridge.MethodId _Device2452;
			public Device() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.bluetooth.BluetoothClass.Device.staticClass, global::android.bluetooth.BluetoothClass.Device._Device2452);
				Init(@__env, handle);
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.bluetooth.BluetoothClass.Device.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/bluetooth/BluetoothClass$Device"));
				global::android.bluetooth.BluetoothClass.Device._Device2452 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothClass.Device.staticClass, "<init>", "()V");
			}
		}
		[global::MonoJavaBridge.JavaClass()]
		public sealed partial class Service : java.lang.Object
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Service()
			{
				InitJNI();
			}
			internal Service(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _Service2503;
			public Service() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.bluetooth.BluetoothClass.Service.staticClass, global::android.bluetooth.BluetoothClass.Service._Service2503);
				Init(@__env, handle);
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
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.bluetooth.BluetoothClass.Service.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/bluetooth/BluetoothClass$Service"));
				global::android.bluetooth.BluetoothClass.Service._Service2503 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothClass.Service.staticClass, "<init>", "()V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _equals2513;
		public sealed override bool equals(java.lang.Object arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass._equals2513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass.staticClass, global::android.bluetooth.BluetoothClass._equals2513, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _toString2514;
		public sealed override global::java.lang.String toString()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass._toString2514)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass.staticClass, global::android.bluetooth.BluetoothClass._toString2514)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _hashCode2515;
		public sealed override int hashCode()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass._hashCode2515);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass.staticClass, global::android.bluetooth.BluetoothClass._hashCode2515);
		}
		internal static global::MonoJavaBridge.MethodId _writeToParcel2516;
		public void writeToParcel(android.os.Parcel arg0, int arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass._writeToParcel2516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass.staticClass, global::android.bluetooth.BluetoothClass._writeToParcel2516, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _describeContents2517;
		public int describeContents()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass._describeContents2517);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass.staticClass, global::android.bluetooth.BluetoothClass._describeContents2517);
		}
		internal static global::MonoJavaBridge.MethodId _hasService2518;
		public bool hasService(int arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass._hasService2518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass.staticClass, global::android.bluetooth.BluetoothClass._hasService2518, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new int MajorDeviceClass
		{
			get
			{
				return getMajorDeviceClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMajorDeviceClass2519;
		public int getMajorDeviceClass()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass._getMajorDeviceClass2519);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass.staticClass, global::android.bluetooth.BluetoothClass._getMajorDeviceClass2519);
		}
		public new int DeviceClass
		{
			get
			{
				return getDeviceClass();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getDeviceClass2520;
		public int getDeviceClass()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass._getDeviceClass2520);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.bluetooth.BluetoothClass.staticClass, global::android.bluetooth.BluetoothClass._getDeviceClass2520);
		}
		internal static global::MonoJavaBridge.FieldId _CREATOR2521;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.bluetooth.BluetoothClass.staticClass, _CREATOR2521)) as android.os.Parcelable_Creator;
			}
		}
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.bluetooth.BluetoothClass.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/bluetooth/BluetoothClass"));
			global::android.bluetooth.BluetoothClass._equals2513 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothClass.staticClass, "equals", "(Ljava/lang/Object;)Z");
			global::android.bluetooth.BluetoothClass._toString2514 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothClass.staticClass, "toString", "()Ljava/lang/String;");
			global::android.bluetooth.BluetoothClass._hashCode2515 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothClass.staticClass, "hashCode", "()I");
			global::android.bluetooth.BluetoothClass._writeToParcel2516 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothClass.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.bluetooth.BluetoothClass._describeContents2517 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothClass.staticClass, "describeContents", "()I");
			global::android.bluetooth.BluetoothClass._hasService2518 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothClass.staticClass, "hasService", "(I)Z");
			global::android.bluetooth.BluetoothClass._getMajorDeviceClass2519 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothClass.staticClass, "getMajorDeviceClass", "()I");
			global::android.bluetooth.BluetoothClass._getDeviceClass2520 = @__env.GetMethodIDNoThrow(global::android.bluetooth.BluetoothClass.staticClass, "getDeviceClass", "()I");
			global::android.bluetooth.BluetoothClass._CREATOR2521 = @__env.GetStaticFieldIDNoThrow(global::android.bluetooth.BluetoothClass.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
		}
	}
}
