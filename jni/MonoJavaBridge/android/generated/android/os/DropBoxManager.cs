namespace android.os
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class DropBoxManager : java.lang.Object
	{
		internal static global::java.lang.Class staticClass;
		static DropBoxManager()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.DropBoxManager), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.os.DropBoxManager(@__env);
			}
		}
		protected DropBoxManager(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public class Entry : java.lang.Object, Parcelable
		{
			internal static global::java.lang.Class staticClass;
			static Entry()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.os.DropBoxManager.Entry), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.os.DropBoxManager.Entry(@__env);
				}
			}
			protected Entry(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _close6109;
			public virtual void close() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.os.DropBoxManager.Entry._close6109);
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._close6109);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getInputStream6110;
			public virtual global::java.io.InputStream getInputStream() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.DropBoxManager.Entry._getInputStream6110));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.io.InputStream>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._getInputStream6110));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getTag6111;
			public virtual global::java.lang.String getTag() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.DropBoxManager.Entry._getTag6111));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._getTag6111));
			}
			internal static global::net.sf.jni4net.jni.MethodId _getText6112;
			public virtual global::java.lang.String getText(int arg0) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.DropBoxManager.Entry._getText6112, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
				else
					return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._getText6112, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			}
			internal static global::net.sf.jni4net.jni.MethodId _writeToParcel6113;
			public virtual void writeToParcel(android.os.Parcel arg0, int arg1) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					@__env.CallVoidMethod(this, global::android.os.DropBoxManager.Entry._writeToParcel6113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
				else
					@__env.CallNonVirtualVoidMethod(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._writeToParcel6113, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _describeContents6114;
			public virtual int describeContents() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.os.DropBoxManager.Entry._describeContents6114);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._describeContents6114);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getFlags6115;
			public virtual int getFlags() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallIntMethod(this, global::android.os.DropBoxManager.Entry._getFlags6115);
				else
					return @__env.CallNonVirtualIntMethod(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._getFlags6115);
			}
			internal static global::net.sf.jni4net.jni.MethodId _getTimeMillis6116;
			public virtual long getTimeMillis() 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return @__env.CallLongMethod(this, global::android.os.DropBoxManager.Entry._getTimeMillis6116);
				else
					return @__env.CallNonVirtualLongMethod(this, global::android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._getTimeMillis6116);
			}
			internal static global::net.sf.jni4net.jni.MethodId _Entry6117;
			public Entry(java.lang.String arg0, long arg1)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._Entry6117, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Entry6118;
			public Entry(java.lang.String arg0, long arg1, java.lang.String arg2)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._Entry6118, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Entry6119;
			public Entry(java.lang.String arg0, long arg1, byte[] arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._Entry6119, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Entry6120;
			public Entry(java.lang.String arg0, long arg1, android.os.ParcelFileDescriptor arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._Entry6120, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			internal static global::net.sf.jni4net.jni.MethodId _Entry6121;
			public Entry(java.lang.String arg0, long arg1, java.io.File arg2, int arg3)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				@__env.NewObject(android.os.DropBoxManager.Entry.staticClass, global::android.os.DropBoxManager.Entry._Entry6121, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			}
			internal static global::net.sf.jni4net.jni.FieldId _CREATOR6122;
			public static global::android.os.Parcelable_Creator CREATOR
			{
				get
				{
					return default(global::android.os.Parcelable_Creator);
				}
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.os.DropBoxManager.Entry.staticClass = @__class;
				global::android.os.DropBoxManager.Entry._close6109 = @__env.GetMethodID(global::android.os.DropBoxManager.Entry.staticClass, "close", "()V");
				global::android.os.DropBoxManager.Entry._getInputStream6110 = @__env.GetMethodID(global::android.os.DropBoxManager.Entry.staticClass, "getInputStream", "()Ljava/io/InputStream;");
				global::android.os.DropBoxManager.Entry._getTag6111 = @__env.GetMethodID(global::android.os.DropBoxManager.Entry.staticClass, "getTag", "()Ljava/lang/String;");
				global::android.os.DropBoxManager.Entry._getText6112 = @__env.GetMethodID(global::android.os.DropBoxManager.Entry.staticClass, "getText", "(I)Ljava/lang/String;");
				global::android.os.DropBoxManager.Entry._writeToParcel6113 = @__env.GetMethodID(global::android.os.DropBoxManager.Entry.staticClass, "writeToParcel", "(Landroid/os/Parcel;I)V");
				global::android.os.DropBoxManager.Entry._describeContents6114 = @__env.GetMethodID(global::android.os.DropBoxManager.Entry.staticClass, "describeContents", "()I");
				global::android.os.DropBoxManager.Entry._getFlags6115 = @__env.GetMethodID(global::android.os.DropBoxManager.Entry.staticClass, "getFlags", "()I");
				global::android.os.DropBoxManager.Entry._getTimeMillis6116 = @__env.GetMethodID(global::android.os.DropBoxManager.Entry.staticClass, "getTimeMillis", "()J");
				global::android.os.DropBoxManager.Entry._Entry6117 = @__env.GetMethodID(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;J)V");
				global::android.os.DropBoxManager.Entry._Entry6118 = @__env.GetMethodID(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;JLjava/lang/String;)V");
				global::android.os.DropBoxManager.Entry._Entry6119 = @__env.GetMethodID(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;J[BI)V");
				global::android.os.DropBoxManager.Entry._Entry6120 = @__env.GetMethodID(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;JLandroid/os/ParcelFileDescriptor;I)V");
				global::android.os.DropBoxManager.Entry._Entry6121 = @__env.GetMethodID(global::android.os.DropBoxManager.Entry.staticClass, "<init>", "(Ljava/lang/String;JLjava/io/File;I)V");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _getNextEntry6123;
		public virtual global::android.os.DropBoxManager.Entry getNextEntry(java.lang.String arg0, long arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.DropBoxManager.Entry>(@__env, @__env.CallObjectMethodPtr(this, global::android.os.DropBoxManager._getNextEntry6123, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.DropBoxManager.Entry>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._getNextEntry6123, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addText6124;
		public virtual void addText(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.DropBoxManager._addText6124, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._addText6124, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addData6125;
		public virtual void addData(java.lang.String arg0, byte[] arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.DropBoxManager._addData6125, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._addData6125, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayPrimC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _addFile6126;
		public virtual void addFile(java.lang.String arg0, java.io.File arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.os.DropBoxManager._addFile6126, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._addFile6126, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isTagEnabled6127;
		public virtual bool isTagEnabled(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.os.DropBoxManager._isTagEnabled6127, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._isTagEnabled6127, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _DropBoxManager6128;
		protected DropBoxManager()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			@__env.NewObject(android.os.DropBoxManager.staticClass, global::android.os.DropBoxManager._DropBoxManager6128, this);
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.os.DropBoxManager.staticClass = @__class;
			global::android.os.DropBoxManager._getNextEntry6123 = @__env.GetMethodID(global::android.os.DropBoxManager.staticClass, "getNextEntry", "(Ljava/lang/String;J)Landroid/os/DropBoxManager$Entry;");
			global::android.os.DropBoxManager._addText6124 = @__env.GetMethodID(global::android.os.DropBoxManager.staticClass, "addText", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.os.DropBoxManager._addData6125 = @__env.GetMethodID(global::android.os.DropBoxManager.staticClass, "addData", "(Ljava/lang/String;[BI)V");
			global::android.os.DropBoxManager._addFile6126 = @__env.GetMethodID(global::android.os.DropBoxManager.staticClass, "addFile", "(Ljava/lang/String;Ljava/io/File;I)V");
			global::android.os.DropBoxManager._isTagEnabled6127 = @__env.GetMethodID(global::android.os.DropBoxManager.staticClass, "isTagEnabled", "(Ljava/lang/String;)Z");
			global::android.os.DropBoxManager._DropBoxManager6128 = @__env.GetMethodID(global::android.os.DropBoxManager.staticClass, "<init>", "()V");
		}
	}
}
