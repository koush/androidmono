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
			private static global::MonoJavaBridge.MethodId _m0;
			public virtual void close()
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.DropBoxManager.Entry.staticClass, "close", "()V", ref global::android.os.DropBoxManager.Entry._m0);
			}
			public new global::java.io.InputStream InputStream
			{
				get
				{
					return getInputStream();
				}
			}
			private static global::MonoJavaBridge.MethodId _m1;
			public virtual global::java.io.InputStream getInputStream()
			{
				return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.DropBoxManager.Entry.staticClass, "getInputStream", "()Ljava/io/InputStream;", ref global::android.os.DropBoxManager.Entry._m1) as java.io.InputStream;
			}
			public new global::java.lang.String Tag
			{
				get
				{
					return getTag();
				}
			}
			private static global::MonoJavaBridge.MethodId _m2;
			public virtual global::java.lang.String getTag()
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.DropBoxManager.Entry.staticClass, "getTag", "()Ljava/lang/String;", ref global::android.os.DropBoxManager.Entry._m2) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m3;
			public virtual global::java.lang.String getText(int arg0)
			{
				return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.os.DropBoxManager.Entry.staticClass, "getText", "(I)Ljava/lang/String;", ref global::android.os.DropBoxManager.Entry._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.lang.String;
			}
			private static global::MonoJavaBridge.MethodId _m4;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1)
			{
				global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.DropBoxManager.Entry.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V", ref global::android.os.DropBoxManager.Entry._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			private static global::MonoJavaBridge.MethodId _m5;
			public virtual int describeContents()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.DropBoxManager.Entry.staticClass, "describeContents", "()I", ref global::android.os.DropBoxManager.Entry._m5);
			}
			public new int Flags
			{
				get
				{
					return getFlags();
				}
			}
			private static global::MonoJavaBridge.MethodId _m6;
			public virtual int getFlags()
			{
				return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.os.DropBoxManager.Entry.staticClass, "getFlags", "()I", ref global::android.os.DropBoxManager.Entry._m6);
			}
			public new long TimeMillis
			{
				get
				{
					return getTimeMillis();
				}
			}
			private static global::MonoJavaBridge.MethodId _m7;
			public virtual long getTimeMillis()
			{
				return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.os.DropBoxManager.Entry.staticClass, "getTimeMillis", "()J", ref global::android.os.DropBoxManager.Entry._m7);
			}
			private static global::MonoJavaBridge.MethodId _m8;
			public Entry(java.lang.String arg0, long arg1) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._m8.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._m8 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;J)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m9;
			public Entry(java.lang.String arg0, long arg1, java.lang.String arg2) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._m9.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._m9 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;JLjava/lang/String;)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m10;
			public Entry(java.lang.String arg0, long arg1, byte[] arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._m10.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._m10 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;J[BI)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m11;
			public Entry(java.lang.String arg0, long arg1, android.os.ParcelFileDescriptor arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._m11.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._m11 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;JLandroid/os/ParcelFileDescriptor;I)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				Init(@__env, handle);
			}
			private static global::MonoJavaBridge.MethodId _m12;
			public Entry(java.lang.String arg0, long arg1, java.io.File arg2, int arg3) : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.os.DropBoxManager.Entry._m12.native == global::System.IntPtr.Zero)
					global::android.os.DropBoxManager.Entry._m12 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;JLjava/io/File;I)V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR3962;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.os.Parcelable_Creator>(@__env.GetStaticObjectField(global::android.os.DropBoxManager.Entry.staticClass, _CREATOR3962)) as android.os.Parcelable_Creator;
				}
			}
			static Entry()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.DropBoxManager.Entry.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/DropBoxManager$Entry"));
				global::android.os.DropBoxManager.Entry._CREATOR3962 = @__env.GetStaticFieldIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "CREATOR", "Landroid/os/Parcelable$Creator;");
			}
			internal static void InitJNI()
			{
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		public virtual global::android.os.DropBoxManager.Entry getNextEntry(java.lang.String arg0, long arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.os.DropBoxManager.staticClass, "getNextEntry", "(Ljava/lang/String;J)Landroid/os/DropBoxManager$Entry;", ref global::android.os.DropBoxManager._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.os.DropBoxManager.Entry;
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual void addText(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.DropBoxManager.staticClass, "addText", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.os.DropBoxManager._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void addData(java.lang.String arg0, byte[] arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.DropBoxManager.staticClass, "addData", "(Ljava/lang/String;[BI)V", ref global::android.os.DropBoxManager._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual void addFile(java.lang.String arg0, java.io.File arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.os.DropBoxManager.staticClass, "addFile", "(Ljava/lang/String;Ljava/io/File;I)V", ref global::android.os.DropBoxManager._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual bool isTagEnabled(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.os.DropBoxManager.staticClass, "isTagEnabled", "(Ljava/lang/String;)Z", ref global::android.os.DropBoxManager._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		protected DropBoxManager() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.os.DropBoxManager._m5.native == global::System.IntPtr.Zero)
				global::android.os.DropBoxManager._m5 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.staticClass, "<init>", "()V");
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._m5);
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
