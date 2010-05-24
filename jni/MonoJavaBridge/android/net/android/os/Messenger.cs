namespace android.os 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public sealed class Messenger : java.lang.Object, Parcelable
	{ 
		internal static global::java.lang.Class staticClass; 
		static Messenger() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.os.Messenger), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.os.Messenger(@__env); 
			} 
		} 
		internal Messenger(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _hashCode5679; 
		public sealed override int hashCode() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Messenger)) 
				return @__env.CallIntMethod(this, _hashCode5679); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.Messenger.staticClass, _hashCode5679); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _equals5680; 
		public sealed override bool equals(java.lang.Object arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Messenger)) 
				return @__env.CallBooleanMethod(this, _equals5680, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.os.Messenger.staticClass, _equals5680, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _send5681; 
		public void send(android.os.Message arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Messenger)) 
				@__env.CallVoidMethod(this, _send5681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Messenger.staticClass, _send5681, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel5682; 
		public void writeToParcel(android.os.Parcel arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Messenger)) 
				@__env.CallVoidMethod(this, _writeToParcel5682, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.os.Messenger.staticClass, _writeToParcel5682, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _describeContents5683; 
		public int describeContents() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Messenger)) 
				return @__env.CallIntMethod(this, _describeContents5683); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.os.Messenger.staticClass, _describeContents5683); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBinder5684; 
		public android.os.IBinder getBinder() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.os.Messenger)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallObjectMethodPtr(this, _getBinder5684)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.os.IBinder>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.os.Messenger.staticClass, _getBinder5684)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _writeMessengerOrNullToParcel5685; 
		public static void writeMessengerOrNullToParcel(android.os.Messenger arg0, android.os.Parcel arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.CallStaticVoidMethod(android.os.Messenger.staticClass, _writeMessengerOrNullToParcel5685, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _readMessengerOrNullFromParcel5686; 
		public static android.os.Messenger readMessengerOrNullFromParcel(android.os.Parcel arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Messenger>(@__env, @__env.CallStaticObjectMethodPtr(android.os.Messenger.staticClass, _readMessengerOrNullFromParcel5686, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Messenger5687; 
		public Messenger(android.os.Handler arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Messenger.staticClass, _Messenger5687, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _Messenger5688; 
		public Messenger(android.os.IBinder arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.os.Messenger.staticClass, _Messenger5688, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR5689; 
		public static android.os.Parcelable_Creator CREATOR
		{ 
			get 
			{ 
				return default(android.os.Parcelable_Creator); 
			} 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.os.Messenger.staticClass = @__class; 
			global::android.os.Messenger._hashCode5679 = @__env.GetMethodID(global::android.os.Messenger.staticClass, "hashCode", "()I"); 
			global::android.os.Messenger._equals5680 = @__env.GetMethodID(global::android.os.Messenger.staticClass, "equals", "(Ljava/lang/Object;)Z"); 
			global::android.os.Messenger._send5681 = @__env.GetMethodID(global::android.os.Messenger.staticClass, "send", "(Landroid/os/Message;)V"); 
			global::android.os.Messenger._writeToParcel5682 = @__env.GetMethodID(global::android.os.Messenger.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V"); 
			global::android.os.Messenger._describeContents5683 = @__env.GetMethodID(global::android.os.Messenger.staticClass, "describeContents", "()I"); 
			global::android.os.Messenger._getBinder5684 = @__env.GetMethodID(global::android.os.Messenger.staticClass, "getBinder", "()Landroid/os/IBinder;"); 
			global::android.os.Messenger._writeMessengerOrNullToParcel5685 = @__env.GetStaticMethodID(global::android.os.Messenger.staticClass, "writeMessengerOrNullToParcel", "(Landroid/os/Messenger;Landroid/os/Parcel;)V"); 
			global::android.os.Messenger._readMessengerOrNullFromParcel5686 = @__env.GetStaticMethodID(global::android.os.Messenger.staticClass, "readMessengerOrNullFromParcel", "(Landroid/os/Parcel;)Landroid/os/Messenger;"); 
			global::android.os.Messenger._Messenger5687 = @__env.GetMethodID(global::android.os.Messenger.staticClass, "<init>", "(Landroid/os/Handler;)V"); 
			global::android.os.Messenger._Messenger5688 = @__env.GetMethodID(global::android.os.Messenger.staticClass, "<init>", "(Landroid/os/IBinder;)V"); 
		} 
	} 
} 
