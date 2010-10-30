namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteDatabase : android.database.sqlite.SQLiteClosable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		protected SQLiteDatabase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.database.sqlite.SQLiteDatabase.CursorFactory_))]
		public partial interface CursorFactory  : global::MonoJavaBridge.IJavaObject 
		{
			global::android.database.Cursor newCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.sqlite.SQLiteDatabase.CursorFactory))]
		internal sealed partial class CursorFactory_ : java.lang.Object, CursorFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			internal CursorFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			global::android.database.Cursor android.database.sqlite.SQLiteDatabase.CursorFactory.newCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3)
			{
				return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.database.sqlite.SQLiteDatabase.CursorFactory_.staticClass, "newCursor", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/database/sqlite/SQLiteCursorDriver;Ljava/lang/String;Landroid/database/sqlite/SQLiteQuery;)Landroid/database/Cursor;", ref global::android.database.sqlite.SQLiteDatabase.CursorFactory_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.database.Cursor;
			}
			static CursorFactory_()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.sqlite.SQLiteDatabase.CursorFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteDatabase$CursorFactory"));
			}
			internal static void InitJNI()
			{
			}
		}

		public delegate android.database.Cursor CursorFactoryDelegate(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3);

		internal partial class CursorFactoryDelegateWrapper : java.lang.Object, CursorFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			protected CursorFactoryDelegateWrapper(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			private static global::MonoJavaBridge.MethodId _m0;
			public CursorFactoryDelegateWrapper() : base(global::MonoJavaBridge.JNIEnv.ThreadEnv)
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper._m0.native == global::System.IntPtr.Zero)
					global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper._m0 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper.staticClass, "<init>", "()V");
				global::MonoJavaBridge.JniLocalHandle handle = @__env.NewObject(android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper.staticClass, global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper._m0);
				Init(@__env, handle);
			}
			static CursorFactoryDelegateWrapper()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteDatabase_CursorFactoryDelegateWrapper"));
			}
			internal static void InitJNI()
			{
			}
		}
		internal partial class CursorFactoryDelegateWrapper
		{
			private CursorFactoryDelegate myDelegate;
			public android.database.Cursor newCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3)
			{
				return myDelegate(arg0, arg1, arg2, arg3);
			}
			public static implicit operator CursorFactoryDelegateWrapper(CursorFactoryDelegate d)
			{
				global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper ret = new global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper();
				ret.myDelegate = d;
				global::MonoJavaBridge.JavaBridge.SetGCHandle(global::MonoJavaBridge.JNIEnv.ThreadEnv, ret);
				return ret;
			}
		}
		private static global::MonoJavaBridge.MethodId _m0;
		protected override void finalize()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "finalize", "()V", ref global::android.database.sqlite.SQLiteDatabase._m0);
		}
		private static global::MonoJavaBridge.MethodId _m1;
		public virtual long replace(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "replace", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J", ref global::android.database.sqlite.SQLiteDatabase._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		public virtual void close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "close", "()V", ref global::android.database.sqlite.SQLiteDatabase._m2);
		}
		private static global::MonoJavaBridge.MethodId _m3;
		public virtual int delete(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "delete", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)I", ref global::android.database.sqlite.SQLiteDatabase._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		public virtual long insert(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "insert", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J", ref global::android.database.sqlite.SQLiteDatabase._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		public virtual bool isReadOnly()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "isReadOnly", "()Z", ref global::android.database.sqlite.SQLiteDatabase._m5);
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		private static global::MonoJavaBridge.MethodId _m6;
		public virtual global::java.lang.String getPath()
		{
			return global::MonoJavaBridge.JavaBridge.CallSealedClassObjectMethod<java.lang.String>(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "getPath", "()Ljava/lang/String;", ref global::android.database.sqlite.SQLiteDatabase._m6) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m7;
		public virtual global::android.database.Cursor query(bool arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String[] arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7, java.lang.String arg8)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "query", "(ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.database.sqlite.SQLiteDatabase._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8)) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m8;
		public virtual global::android.database.Cursor query(java.lang.String arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.database.sqlite.SQLiteDatabase._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7)) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m9;
		public virtual global::android.database.Cursor query(java.lang.String arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.database.sqlite.SQLiteDatabase._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6)) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m10;
		public static global::android.database.sqlite.SQLiteDatabase create(android.database.sqlite.SQLiteDatabase.CursorFactory arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteDatabase._m10.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteDatabase._m10 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "create", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.sqlite.SQLiteDatabase;
		}
		public static android.database.sqlite.SQLiteDatabase create(global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg0)
		{
			return create((global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg0);
		}
		private static global::MonoJavaBridge.MethodId _m11;
		public virtual bool isOpen()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "isOpen", "()Z", ref global::android.database.sqlite.SQLiteDatabase._m11);
		}
		private static global::MonoJavaBridge.MethodId _m12;
		public virtual int update(java.lang.String arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "update", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I", ref global::android.database.sqlite.SQLiteDatabase._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		public new int Version
		{
			get
			{
				return getVersion();
			}
			set
			{
				setVersion(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m13;
		public virtual int getVersion()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "getVersion", "()I", ref global::android.database.sqlite.SQLiteDatabase._m13);
		}
		private static global::MonoJavaBridge.MethodId _m14;
		public virtual void setVersion(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "setVersion", "(I)V", ref global::android.database.sqlite.SQLiteDatabase._m14, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new global::java.util.Locale Locale
		{
			set
			{
				setLocale(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m15;
		public virtual void setLocale(java.util.Locale arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "setLocale", "(Ljava/util/Locale;)V", ref global::android.database.sqlite.SQLiteDatabase._m15, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m16;
		public static global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, android.database.sqlite.SQLiteDatabase.CursorFactory arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteDatabase._m16.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteDatabase._m16 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.database.sqlite.SQLiteDatabase;
		}
		public static android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg1)
		{
			return openOrCreateDatabase(arg0, (global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m17;
		public static global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.io.File arg0, android.database.sqlite.SQLiteDatabase.CursorFactory arg1)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteDatabase._m17.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteDatabase._m17 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "openOrCreateDatabase", "(Ljava/io/File;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.database.sqlite.SQLiteDatabase;
		}
		public static android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.io.File arg0, global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg1)
		{
			return openOrCreateDatabase(arg0, (global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg1);
		}
		private static global::MonoJavaBridge.MethodId _m18;
		protected override void onAllReferencesReleased()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "onAllReferencesReleased", "()V", ref global::android.database.sqlite.SQLiteDatabase._m18);
		}
		private static global::MonoJavaBridge.MethodId _m19;
		public static int releaseMemory()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteDatabase._m19.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteDatabase._m19 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "releaseMemory", "()I");
			return @__env.CallStaticIntMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._m19);
		}
		public new bool LockingEnabled
		{
			set
			{
				setLockingEnabled(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m20;
		public virtual void setLockingEnabled(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "setLockingEnabled", "(Z)V", ref global::android.database.sqlite.SQLiteDatabase._m20, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m21;
		public virtual void beginTransaction()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "beginTransaction", "()V", ref global::android.database.sqlite.SQLiteDatabase._m21);
		}
		private static global::MonoJavaBridge.MethodId _m22;
		public virtual void beginTransactionWithListener(android.database.sqlite.SQLiteTransactionListener arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "beginTransactionWithListener", "(Landroid/database/sqlite/SQLiteTransactionListener;)V", ref global::android.database.sqlite.SQLiteDatabase._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		public virtual void endTransaction()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "endTransaction", "()V", ref global::android.database.sqlite.SQLiteDatabase._m23);
		}
		private static global::MonoJavaBridge.MethodId _m24;
		public virtual void setTransactionSuccessful()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "setTransactionSuccessful", "()V", ref global::android.database.sqlite.SQLiteDatabase._m24);
		}
		private static global::MonoJavaBridge.MethodId _m25;
		public virtual bool inTransaction()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "inTransaction", "()Z", ref global::android.database.sqlite.SQLiteDatabase._m25);
		}
		private static global::MonoJavaBridge.MethodId _m26;
		public virtual bool isDbLockedByCurrentThread()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "isDbLockedByCurrentThread", "()Z", ref global::android.database.sqlite.SQLiteDatabase._m26);
		}
		private static global::MonoJavaBridge.MethodId _m27;
		public virtual bool isDbLockedByOtherThreads()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "isDbLockedByOtherThreads", "()Z", ref global::android.database.sqlite.SQLiteDatabase._m27);
		}
		private static global::MonoJavaBridge.MethodId _m28;
		public virtual bool yieldIfContended()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "yieldIfContended", "()Z", ref global::android.database.sqlite.SQLiteDatabase._m28);
		}
		private static global::MonoJavaBridge.MethodId _m29;
		public virtual bool yieldIfContendedSafely(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "yieldIfContendedSafely", "(J)Z", ref global::android.database.sqlite.SQLiteDatabase._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		public virtual bool yieldIfContendedSafely()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "yieldIfContendedSafely", "()Z", ref global::android.database.sqlite.SQLiteDatabase._m30);
		}
		public new global::java.util.Map SyncedTables
		{
			get
			{
				return getSyncedTables();
			}
		}
		private static global::MonoJavaBridge.MethodId _m31;
		public virtual global::java.util.Map getSyncedTables()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.util.Map>(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "getSyncedTables", "()Ljava/util/Map;", ref global::android.database.sqlite.SQLiteDatabase._m31) as java.util.Map;
		}
		private static global::MonoJavaBridge.MethodId _m32;
		public static global::android.database.sqlite.SQLiteDatabase openDatabase(java.lang.String arg0, android.database.sqlite.SQLiteDatabase.CursorFactory arg1, int arg2)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteDatabase._m32.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteDatabase._m32 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "openDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;I)Landroid/database/sqlite/SQLiteDatabase;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.sqlite.SQLiteDatabase;
		}
		public static android.database.sqlite.SQLiteDatabase openDatabase(java.lang.String arg0, global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg1, int arg2)
		{
			return openDatabase(arg0, (global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg1, arg2);
		}
		public new long MaximumSize
		{
			get
			{
				return getMaximumSize();
			}
			set
			{
				setMaximumSize(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m33;
		public virtual long getMaximumSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "getMaximumSize", "()J", ref global::android.database.sqlite.SQLiteDatabase._m33);
		}
		private static global::MonoJavaBridge.MethodId _m34;
		public virtual long setMaximumSize(long arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "setMaximumSize", "(J)J", ref global::android.database.sqlite.SQLiteDatabase._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public new long PageSize
		{
			get
			{
				return getPageSize();
			}
			set
			{
				setPageSize(value);
			}
		}
		private static global::MonoJavaBridge.MethodId _m35;
		public virtual long getPageSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "getPageSize", "()J", ref global::android.database.sqlite.SQLiteDatabase._m35);
		}
		private static global::MonoJavaBridge.MethodId _m36;
		public virtual void setPageSize(long arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "setPageSize", "(J)V", ref global::android.database.sqlite.SQLiteDatabase._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		public virtual void markTableSyncable(java.lang.String arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "markTableSyncable", "(Ljava/lang/String;Ljava/lang/String;)V", ref global::android.database.sqlite.SQLiteDatabase._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		public virtual void markTableSyncable(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "markTableSyncable", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V", ref global::android.database.sqlite.SQLiteDatabase._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		public static global::java.lang.String findEditTable(java.lang.String arg0)
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (global::android.database.sqlite.SQLiteDatabase._m39.native == global::System.IntPtr.Zero)
				global::android.database.sqlite.SQLiteDatabase._m39 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "findEditTable", "(Ljava/lang/String;)Ljava/lang/String;");
			return global::MonoJavaBridge.JavaBridge.WrapJavaObjectSealedClass<java.lang.String>(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		private static global::MonoJavaBridge.MethodId _m40;
		public virtual global::android.database.sqlite.SQLiteStatement compileStatement(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "compileStatement", "(Ljava/lang/String;)Landroid/database/sqlite/SQLiteStatement;", ref global::android.database.sqlite.SQLiteDatabase._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as android.database.sqlite.SQLiteStatement;
		}
		private static global::MonoJavaBridge.MethodId _m41;
		public virtual global::android.database.Cursor queryWithFactory(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, bool arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String[] arg5, java.lang.String arg6, java.lang.String arg7, java.lang.String arg8, java.lang.String arg9)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "queryWithFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.database.sqlite.SQLiteDatabase._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9)) as android.database.Cursor;
		}
		public android.database.Cursor queryWithFactory(global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg0, bool arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String[] arg5, java.lang.String arg6, java.lang.String arg7, java.lang.String arg8, java.lang.String arg9)
		{
			return queryWithFactory((global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg0, arg1, arg2, arg3, arg4, arg5, arg6, arg7, arg8, arg9);
		}
		private static global::MonoJavaBridge.MethodId _m42;
		public virtual global::android.database.Cursor rawQuery(java.lang.String arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "rawQuery", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.database.sqlite.SQLiteDatabase._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1)) as android.database.Cursor;
		}
		private static global::MonoJavaBridge.MethodId _m43;
		public virtual global::android.database.Cursor rawQueryWithFactory(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<android.database.Cursor>(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "rawQueryWithFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;", ref global::android.database.sqlite.SQLiteDatabase._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3)) as android.database.Cursor;
		}
		public android.database.Cursor rawQueryWithFactory(global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegate arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3)
		{
			return rawQueryWithFactory((global::android.database.sqlite.SQLiteDatabase.CursorFactoryDelegateWrapper)arg0, arg1, arg2, arg3);
		}
		private static global::MonoJavaBridge.MethodId _m44;
		public virtual long insertOrThrow(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "insertOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J", ref global::android.database.sqlite.SQLiteDatabase._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		public virtual long replaceOrThrow(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "replaceOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J", ref global::android.database.sqlite.SQLiteDatabase._m45, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m46;
		public virtual long insertWithOnConflict(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2, int arg3)
		{
			return global::MonoJavaBridge.JavaBridge.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "insertWithOnConflict", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;I)J", ref global::android.database.sqlite.SQLiteDatabase._m46, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m47;
		public virtual int updateWithOnConflict(java.lang.String arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3, int arg4)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "updateWithOnConflict", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;I)I", ref global::android.database.sqlite.SQLiteDatabase._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		public virtual void execSQL(java.lang.String arg0, java.lang.Object[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "execSQL", "(Ljava/lang/String;[Ljava/lang/Object;)V", ref global::android.database.sqlite.SQLiteDatabase._m48, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m49;
		public virtual void execSQL(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "execSQL", "(Ljava/lang/String;)V", ref global::android.database.sqlite.SQLiteDatabase._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		public virtual bool needUpgrade(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, "needUpgrade", "(I)Z", ref global::android.database.sqlite.SQLiteDatabase._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		public static int CONFLICT_ROLLBACK
		{
			get
			{
				return 1;
			}
		}
		public static int CONFLICT_ABORT
		{
			get
			{
				return 2;
			}
		}
		public static int CONFLICT_FAIL
		{
			get
			{
				return 3;
			}
		}
		public static int CONFLICT_IGNORE
		{
			get
			{
				return 4;
			}
		}
		public static int CONFLICT_REPLACE
		{
			get
			{
				return 5;
			}
		}
		public static int CONFLICT_NONE
		{
			get
			{
				return 0;
			}
		}
		public static int SQLITE_MAX_LIKE_PATTERN_LENGTH
		{
			get
			{
				return 50000;
			}
		}
		public static int OPEN_READWRITE
		{
			get
			{
				return 0;
			}
		}
		public static int OPEN_READONLY
		{
			get
			{
				return 1;
			}
		}
		public static int NO_LOCALIZED_COLLATORS
		{
			get
			{
				return 16;
			}
		}
		public static int CREATE_IF_NECESSARY
		{
			get
			{
				return 268435456;
			}
		}
		static SQLiteDatabase()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteDatabase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteDatabase"));
		}
		internal static void InitJNI()
		{
		}
	}
}
