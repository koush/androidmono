namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DropBoxManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected DropBoxManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Entry : java.lang.Object, Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected Entry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _close9785;
			public virtual void close()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._close9785.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._close9785 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "close", "()V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._close9785);
			}
			public new global::java.io.InputStream InputStream
			{
				get
				{
					return getInputStream();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getInputStream9786;
			public virtual global::java.io.InputStream getInputStream()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._getInputStream9786.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._getInputStream9786 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "getInputStream", "()Ljava/io/InputStream;");
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._getInputStream9786) as java.io.InputStream;
			}
			public new global::java.lang.String Tag
			{
				get
				{
					return getTag();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTag9787;
			public virtual global::java.lang.String getTag()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._getTag9787.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._getTag9787 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "getTag", "()Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._getTag9787) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getText9788;
			public virtual global::java.lang.String getText(int arg0)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._getText9788.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._getText9788 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "getText", "(I)Ljava/lang/String;");
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._getText9788, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel9789;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._writeToParcel9789.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._writeToParcel9789 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._writeToParcel9789, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents9790;
			public virtual int describeContents()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._describeContents9790.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._describeContents9790 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "describeContents", "()I");
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._describeContents9790);
			}
			public new int Flags
			{
				get
				{
					return getFlags();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getFlags9791;
			public virtual int getFlags()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._getFlags9791.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._getFlags9791 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "getFlags", "()I");
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._getFlags9791);
			}
			public new long TimeMillis
			{
				get
				{
					return getTimeMillis();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTimeMillis9792;
			public virtual long getTimeMillis()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._getTimeMillis9792.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._getTimeMillis9792 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "getTimeMillis", "()J");
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._getTimeMillis9792);
			}
			internal static global::MonoJavaBridge.MethodId _Entry9793;
			public Entry(java.lang.String arg0, long arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._Entry9793.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._Entry9793 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;J)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._Entry9793, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _Entry9794;
			public Entry(java.lang.String arg0, long arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._Entry9794.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._Entry9794 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;JLjava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._Entry9794, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _Entry9795;
			public Entry(java.lang.String arg0, long arg1, byte[] arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._Entry9795.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._Entry9795 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;J[BI)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._Entry9795, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _Entry9796;
			public Entry(java.lang.String arg0, long arg1, android.os.ParcelFileDescriptor arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._Entry9796.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._Entry9796 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;JLandroid/os/ParcelFileDescriptor;I)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._Entry9796, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _Entry9797;
			public Entry(java.lang.String arg0, long arg1, java.io.File arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._Entry9797.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._Entry9797 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;JLjava/io/File;I)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._Entry9797, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR9798;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.DropBoxManager.Entry.staticClass, _CREATOR9798)) as android.os.Parcelable_Creator;
				}
			}
			static Entry()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.DropBoxManager.Entry.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/DropBoxManager$Entry"));
				global::android.os.DropBoxManager.Entry._CREATOR9798 = @__env.GetStaticFieldIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
			internal static void InitJNI()
			{
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextEntry9799;
		public virtual global::android.os.DropBoxManager.Entry getNextEntry(java.lang.String arg0, long arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.DropBoxManager._getNextEntry9799.native == global::System.IntPtr.Zero)
				global::android.os.DropBoxManager._getNextEntry9799 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.staticClass, "getNextEntry", "(Ljava/lang/String;J)Landroid/os/DropBoxManager$Entry;");
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._getNextEntry9799, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.os.DropBoxManager.Entry;
		}
		internal static global::MonoJavaBridge.MethodId _addText9800;
		public virtual void addText(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.DropBoxManager._addText9800.native == global::System.IntPtr.Zero)
				global::android.os.DropBoxManager._addText9800 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.staticClass, "addText", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._addText9800, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addData9801;
		public virtual void addData(java.lang.String arg0, byte[] arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.DropBoxManager._addData9801.native == global::System.IntPtr.Zero)
				global::android.os.DropBoxManager._addData9801 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.staticClass, "addData", "(Ljava/lang/String;[BI)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._addData9801, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addFile9802;
		public virtual void addFile(java.lang.String arg0, java.io.File arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.DropBoxManager._addFile9802.native == global::System.IntPtr.Zero)
				global::android.os.DropBoxManager._addFile9802 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.staticClass, "addFile", "(Ljava/lang/String;Ljava/io/File;I)V");
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._addFile9802, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isTagEnabled9803;
		public virtual bool isTagEnabled(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.DropBoxManager._isTagEnabled9803.native == global::System.IntPtr.Zero)
				global::android.os.DropBoxManager._isTagEnabled9803 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.staticClass, "isTagEnabled", "(Ljava/lang/String;)Z");
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._isTagEnabled9803, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DropBoxManager9804;
		protected DropBoxManager() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.DropBoxManager._DropBoxManager9804.native == global::System.IntPtr.Zero)
				global::android.os.DropBoxManager._DropBoxManager9804 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._DropBoxManager9804);
			Init(@__env, handle);
		}
		public static int IS_EMPTY
		{
			get
			{
				return 1;
			}
		}
		public static int IS_TEXT
		{
			get
			{
				return 2;
			}
		}
		public static int IS_GZIPPED
		{
			get
			{
				return 4;
			}
		}
		static DropBoxManager()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.DropBoxManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/DropBoxManager"));
		}
		internal static void InitJNI()
		{
		}
	}
}
