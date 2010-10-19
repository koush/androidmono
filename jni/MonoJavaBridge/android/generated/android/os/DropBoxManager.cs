namespace android.os
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class DropBoxManager : java.lang.Object
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static DropBoxManager()
		{
			InitJNI();
		}
		protected DropBoxManager(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaClass()]
		public partial class Entry : java.lang.Object, Parcelable
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static Entry()
			{
				InitJNI();
			}
			protected Entry(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _close6377;
			public virtual void close() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry._close6377);
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._close6377);
			}
			public new global::java.io.InputStream InputStream
			{
				get
				{
					return getInputStream();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getInputStream6378;
			public virtual global::java.io.InputStream getInputStream() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry._getInputStream6378)) as java.io.InputStream;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._getInputStream6378)) as java.io.InputStream;
			}
			public new global::java.lang.String Tag
			{
				get
				{
					return getTag();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTag6379;
			public virtual global::java.lang.String getTag() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry._getTag6379)) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._getTag6379)) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _getText6380;
			public virtual global::java.lang.String getText(int arg0) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry._getText6380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
				else
					return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._getText6380, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
			}
			internal static global::MonoJavaBridge.MethodId _writeToParcel6381;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry._writeToParcel6381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._writeToParcel6381, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			}
			internal static global::MonoJavaBridge.MethodId _describeContents6382;
			public virtual int describeContents() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry._describeContents6382);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._describeContents6382);
			}
			public new int Flags
			{
				get
				{
					return getFlags();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getFlags6383;
			public virtual int getFlags() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry._getFlags6383);
				else
					return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._getFlags6383);
			}
			public new long TimeMillis
			{
				get
				{
					return getTimeMillis();
				}
			}
			internal static global::MonoJavaBridge.MethodId _getTimeMillis6384;
			public virtual long getTimeMillis() 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry._getTimeMillis6384);
				else
					return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._getTimeMillis6384);
			}
			internal static global::MonoJavaBridge.MethodId _Entry6385;
			public Entry(java.lang.String arg0, long arg1)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._Entry6385, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _Entry6386;
			public Entry(java.lang.String arg0, long arg1, java.lang.String arg2)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._Entry6386, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _Entry6387;
			public Entry(java.lang.String arg0, long arg1, byte[] arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._Entry6387, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _Entry6388;
			public Entry(java.lang.String arg0, long arg1, android.os.ParcelFileDescriptor arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._Entry6388, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.MethodId _Entry6389;
			public Entry(java.lang.String arg0, long arg1, java.io.File arg2, int arg3)  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._Entry6389, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
				Init(@__env, handle);
			}
			internal static global::MonoJavaBridge.FieldId _CREATOR6390;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.os.DropBoxManager.Entry.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/DropBoxManager$Entry"));
				global::android.os.DropBoxManager.Entry._close6377 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "close", "()V");
				global::android.os.DropBoxManager.Entry._getInputStream6378 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "getInputStream", "()Ljava/io/InputStream;");
				global::android.os.DropBoxManager.Entry._getTag6379 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "getTag", "()Ljava/lang/String;");
				global::android.os.DropBoxManager.Entry._getText6380 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "getText", "(I)Ljava/lang/String;");
				global::android.os.DropBoxManager.Entry._writeToParcel6381 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.os.DropBoxManager.Entry._describeContents6382 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "describeContents", "()I");
				global::android.os.DropBoxManager.Entry._getFlags6383 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "getFlags", "()I");
				global::android.os.DropBoxManager.Entry._getTimeMillis6384 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "getTimeMillis", "()J");
				global::android.os.DropBoxManager.Entry._Entry6385 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;J)V");
				global::android.os.DropBoxManager.Entry._Entry6386 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;JLjava/lang/String;)V");
				global::android.os.DropBoxManager.Entry._Entry6387 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;J[BI)V");
				global::android.os.DropBoxManager.Entry._Entry6388 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;JLandroid/os/ParcelFileDescriptor;I)V");
				global::android.os.DropBoxManager.Entry._Entry6389 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;JLjava/io/File;I)V");
			}
		}
		internal static global::MonoJavaBridge.MethodId _getNextEntry6391;
		public virtual global::android.os.DropBoxManager.Entry getNextEntry(java.lang.String arg0, long arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.os.DropBoxManager._getNextEntry6391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.DropBoxManager.Entry;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._getNextEntry6391, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.os.DropBoxManager.Entry;
		}
		internal static global::MonoJavaBridge.MethodId _addText6392;
		public virtual void addText(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.DropBoxManager._addText6392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._addText6392, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _addData6393;
		public virtual void addData(java.lang.String arg0, byte[] arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.DropBoxManager._addData6393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._addData6393, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _addFile6394;
		public virtual void addFile(java.lang.String arg0, java.io.File arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.os.DropBoxManager._addFile6394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._addFile6394, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isTagEnabled6395;
		public virtual bool isTagEnabled(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.os.DropBoxManager._isTagEnabled6395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._isTagEnabled6395, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _DropBoxManager6396;
		protected DropBoxManager()  : base(global::MonoJavaBridge.JNIEnv.ThreadEnv) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._DropBoxManager6396);
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.os.DropBoxManager.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/os/DropBoxManager"));
			global::android.os.DropBoxManager._getNextEntry6391 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.staticClass, "getNextEntry", "(Ljava/lang/String;J)Landroid/os/DropBoxManager$Entry;");
			global::android.os.DropBoxManager._addText6392 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.staticClass, "addText", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.os.DropBoxManager._addData6393 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.staticClass, "addData", "(Ljava/lang/String;[BI)V");
			global::android.os.DropBoxManager._addFile6394 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.staticClass, "addFile", "(Ljava/lang/String;Ljava/io/File;I)V");
			global::android.os.DropBoxManager._isTagEnabled6395 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.staticClass, "isTagEnabled", "(Ljava/lang/String;)Z");
			global::android.os.DropBoxManager._DropBoxManager6396 = @__env.GetMethodIDNoThrow(global::android.os.DropBoxManager.staticClass, "<init>", "()V");
		}
	}
}
