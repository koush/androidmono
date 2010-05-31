namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class ParcelFileDescriptor : java.lang.Object, Parcelable
	{
		internal static global::java.lang.Class staticClass;
		static ParcelFileDescriptor()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.ParcelFileDescriptor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.os.ParcelFileDescriptor(@__env);
			}
		}
		protected ParcelFileDescriptor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class AutoCloseInputStream : java.io.FileInputStream
		{
			internal static global::java.lang.Class staticClass;
			static AutoCloseInputStream()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.ParcelFileDescriptor.AutoCloseInputStream), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.os.ParcelFileDescriptor.AutoCloseInputStream(@__env);
				}
			}
			protected AutoCloseInputStream(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _close5790;
			public override void close() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.os.ParcelFileDescriptor.AutoCloseInputStream._close5790);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.os.ParcelFileDescriptor.AutoCloseInputStream.staticClass, global::android.os.ParcelFileDescriptor.AutoCloseInputStream._close5790);
			}
			internal static global::net.sf.jni4net.jni.MethodId _AutoCloseInputStream5791;
			public AutoCloseInputStream(android.os.ParcelFileDescriptor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.os.ParcelFileDescriptor.AutoCloseInputStream.staticClass, global::android.os.ParcelFileDescriptor.AutoCloseInputStream._AutoCloseInputStream5791, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.os.ParcelFileDescriptor.AutoCloseInputStream.staticClass = @__class;
				global::android.os.ParcelFileDescriptor.AutoCloseInputStream._close5790 = @__env.GetMethodID(global::android.os.ParcelFileDescriptor.AutoCloseInputStream.staticClass, "close", "()V");
				global::android.os.ParcelFileDescriptor.AutoCloseInputStream._AutoCloseInputStream5791 = @__env.GetMethodID(global::android.os.ParcelFileDescriptor.AutoCloseInputStream.staticClass, "<init>", "(Landroid/os/ParcelFileDescriptor;)V");
			}
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class AutoCloseOutputStream : java.io.FileOutputStream
		{
			internal new static global::java.lang.Class staticClass;
			static AutoCloseOutputStream()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.ParcelFileDescriptor.AutoCloseOutputStream), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.os.ParcelFileDescriptor.AutoCloseOutputStream(@__env);
				}
			}
			protected AutoCloseOutputStream(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _close5792;
			public override void close() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.os.ParcelFileDescriptor.AutoCloseOutputStream._close5792);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.os.ParcelFileDescriptor.AutoCloseOutputStream.staticClass, global::android.os.ParcelFileDescriptor.AutoCloseOutputStream._close5792);
			}
			internal static global::net.sf.jni4net.jni.MethodId _AutoCloseOutputStream5793;
			public AutoCloseOutputStream(android.os.ParcelFileDescriptor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.os.ParcelFileDescriptor.AutoCloseOutputStream.staticClass, global::android.os.ParcelFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream5793, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.os.ParcelFileDescriptor.AutoCloseOutputStream.staticClass = @__class;
				global::android.os.ParcelFileDescriptor.AutoCloseOutputStream._close5792 = @__env.GetMethodID(global::android.os.ParcelFileDescriptor.AutoCloseOutputStream.staticClass, "close", "()V");
				global::android.os.ParcelFileDescriptor.AutoCloseOutputStream._AutoCloseOutputStream5793 = @__env.GetMethodID(global::android.os.ParcelFileDescriptor.AutoCloseOutputStream.staticClass, "<init>", "(Landroid/os/ParcelFileDescriptor;)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _toString5794;
		public override global::java.lang.String toString() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.ParcelFileDescriptor._toString5794));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._toString5794));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close5795;
		public virtual void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.ParcelFileDescriptor._close5795);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._close5795);
		}
		internal static global::net.sf.jni4net.jni.MethodId _open5796;
		public static global::android.os.ParcelFileDescriptor open(java.io.File arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallStaticObjectMethodPtr(android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._open5796, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _writeToParcel5797;
		public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.ParcelFileDescriptor._writeToParcel5797, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._writeToParcel5797, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _describeContents5798;
		public virtual int describeContents() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.os.ParcelFileDescriptor._describeContents5798);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._describeContents5798);
		}
		internal static global::net.sf.jni4net.jni.MethodId _fromSocket5799;
		public static global::android.os.ParcelFileDescriptor fromSocket(java.net.Socket arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.ParcelFileDescriptor>(@__env, @__env.CallStaticObjectMethodPtr(android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._fromSocket5799, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFileDescriptor5800;
		public virtual global::java.io.FileDescriptor getFileDescriptor() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.ParcelFileDescriptor._getFileDescriptor5800));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.FileDescriptor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._getFileDescriptor5800));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getStatSize5801;
		public virtual long getStatSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.os.ParcelFileDescriptor._getStatSize5801);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._getStatSize5801);
		}
		internal static global::net.sf.jni4net.jni.MethodId _ParcelFileDescriptor5802;
		public ParcelFileDescriptor(android.os.ParcelFileDescriptor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.ParcelFileDescriptor.staticClass, global::android.os.ParcelFileDescriptor._ParcelFileDescriptor5802, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		public static int MODE_WORLD_READABLE
		{
			get
			{
				return 1;
			}
		}
		public static int MODE_WORLD_WRITEABLE
		{
			get
			{
				return 2;
			}
		}
		public static int MODE_READ_ONLY
		{
			get
			{
				return 268435456;
			}
		}
		public static int MODE_WRITE_ONLY
		{
			get
			{
				return 536870912;
			}
		}
		public static int MODE_READ_WRITE
		{
			get
			{
				return 805306368;
			}
		}
		public static int MODE_CREATE
		{
			get
			{
				return 134217728;
			}
		}
		public static int MODE_TRUNCATE
		{
			get
			{
				return 67108864;
			}
		}
		public static int MODE_APPEND
		{
			get
			{
				return 33554432;
			}
		}
		internal static global::net.sf.jni4net.jni.FieldId _CREATOR5803;
		public static global::android.os.Parcelable_Creator CREATOR
		{
			get
			{
				return default(global::android.os.Parcelable_Creator);
			}
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.ParcelFileDescriptor.staticClass = @__class;
			global::android.os.ParcelFileDescriptor._toString5794 = @__env.GetMethodID(global::android.os.ParcelFileDescriptor.staticClass, "toString", "()Ljava/lang/String;");
			global::android.os.ParcelFileDescriptor._close5795 = @__env.GetMethodID(global::android.os.ParcelFileDescriptor.staticClass, "close", "()V");
			global::android.os.ParcelFileDescriptor._open5796 = @__env.GetStaticMethodID(global::android.os.ParcelFileDescriptor.staticClass, "open", "(Ljava/io/File;I)Landroid/os/ParcelFileDescriptor;");
			global::android.os.ParcelFileDescriptor._writeToParcel5797 = @__env.GetMethodID(global::android.os.ParcelFileDescriptor.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
			global::android.os.ParcelFileDescriptor._describeContents5798 = @__env.GetMethodID(global::android.os.ParcelFileDescriptor.staticClass, "describeContents", "()I");
			global::android.os.ParcelFileDescriptor._fromSocket5799 = @__env.GetStaticMethodID(global::android.os.ParcelFileDescriptor.staticClass, "fromSocket", "(Ljava/net/Socket;)Landroid/os/ParcelFileDescriptor;");
			global::android.os.ParcelFileDescriptor._getFileDescriptor5800 = @__env.GetMethodID(global::android.os.ParcelFileDescriptor.staticClass, "getFileDescriptor", "()Ljava/io/FileDescriptor;");
			global::android.os.ParcelFileDescriptor._getStatSize5801 = @__env.GetMethodID(global::android.os.ParcelFileDescriptor.staticClass, "getStatSize", "()J");
			global::android.os.ParcelFileDescriptor._ParcelFileDescriptor5802 = @__env.GetMethodID(global::android.os.ParcelFileDescriptor.staticClass, "<init>", "(Landroid/os/ParcelFileDescriptor;)V");
		}
	}
}
