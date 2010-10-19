namespace android.database.sqlite
{
	[global::MonoJavaBridge.JavaClass()]
	public partial class SQLiteDatabase : android.database.sqlite.SQLiteClosable
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		static SQLiteDatabase()
		{
			InitJNI();
		}
		protected SQLiteDatabase(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		[global::MonoJavaBridge.JavaInterface(typeof(global::android.database.sqlite.SQLiteDatabase.CursorFactory_))]
		public interface CursorFactory  : global::MonoJavaBridge.IJavaObject 
		{
			global::android.database.Cursor newCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3);
		}

		[global::MonoJavaBridge.JavaProxy(typeof(global::android.database.sqlite.SQLiteDatabase.CursorFactory))]
		public sealed partial class CursorFactory_ : java.lang.Object, CursorFactory
		{
			internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
			static CursorFactory_()
			{
				InitJNI();
			}
			internal CursorFactory_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::MonoJavaBridge.MethodId _newCursor2817;
			 global::android.database.Cursor android.database.sqlite.SQLiteDatabase.CursorFactory.newCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3) 
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.CursorFactory_._newCursor2817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.database.Cursor;
				else
					return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.CursorFactory_.staticClass, global::android.database.sqlite.SQLiteDatabase.CursorFactory_._newCursor2817, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.database.Cursor;
			}
			private static void InitJNI()
			{
				global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
				global::android.database.sqlite.SQLiteDatabase.CursorFactory_.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteDatabase$CursorFactory"));
				global::android.database.sqlite.SQLiteDatabase.CursorFactory_._newCursor2817 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.CursorFactory_.staticClass, "newCursor", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/database/sqlite/SQLiteCursorDriver;Ljava/lang/String;Landroid/database/sqlite/SQLiteQuery;)Landroid/database/Cursor;");
			}
		}
		internal static global::MonoJavaBridge.MethodId _finalize2818;
		protected override void finalize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._finalize2818);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._finalize2818);
		}
		internal static global::MonoJavaBridge.MethodId _replace2819;
		public virtual long replace(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._replace2819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._replace2819, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _close2820;
		public virtual void close() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._close2820);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._close2820);
		}
		internal static global::MonoJavaBridge.MethodId _delete2821;
		public virtual int delete(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._delete2821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._delete2821, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _insert2822;
		public virtual long insert(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._insert2822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._insert2822, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _isReadOnly2823;
		public virtual bool isReadOnly() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._isReadOnly2823);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._isReadOnly2823);
		}
		public new global::java.lang.String Path
		{
			get
			{
				return getPath();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getPath2824;
		public virtual global::java.lang.String getPath() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._getPath2824)) as java.lang.String;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._getPath2824)) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _query2825;
		public virtual global::android.database.Cursor query(bool arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String[] arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7, java.lang.String arg8) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._query2825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._query2825, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _query2826;
		public virtual global::android.database.Cursor query(java.lang.String arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._query2826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._query2826, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _query2827;
		public virtual global::android.database.Cursor query(java.lang.String arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._query2827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._query2827, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _create2828;
		public static global::android.database.sqlite.SQLiteDatabase create(android.database.sqlite.SQLiteDatabase.CursorFactory arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._create2828, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.sqlite.SQLiteDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _isOpen2829;
		public virtual bool isOpen() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._isOpen2829);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._isOpen2829);
		}
		internal static global::MonoJavaBridge.MethodId _update2830;
		public virtual int update(java.lang.String arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._update2830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._update2830, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
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
		internal static global::MonoJavaBridge.MethodId _getVersion2831;
		public virtual int getVersion() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._getVersion2831);
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._getVersion2831);
		}
		internal static global::MonoJavaBridge.MethodId _setVersion2832;
		public virtual void setVersion(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._setVersion2832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setVersion2832, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _setLocale2833;
		public virtual void setLocale(java.util.Locale arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._setLocale2833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setLocale2833, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _openOrCreateDatabase2834;
		public static global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, android.database.sqlite.SQLiteDatabase.CursorFactory arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._openOrCreateDatabase2834, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.database.sqlite.SQLiteDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _openOrCreateDatabase2835;
		public static global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.io.File arg0, android.database.sqlite.SQLiteDatabase.CursorFactory arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._openOrCreateDatabase2835, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.database.sqlite.SQLiteDatabase;
		}
		internal static global::MonoJavaBridge.MethodId _onAllReferencesReleased2836;
		protected override void onAllReferencesReleased() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._onAllReferencesReleased2836);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._onAllReferencesReleased2836);
		}
		internal static global::MonoJavaBridge.MethodId _releaseMemory2837;
		public static int releaseMemory() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._releaseMemory2837);
		}
		internal static global::MonoJavaBridge.MethodId _setLockingEnabled2838;
		public virtual void setLockingEnabled(bool arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._setLockingEnabled2838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setLockingEnabled2838, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _beginTransaction2839;
		public virtual void beginTransaction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._beginTransaction2839);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._beginTransaction2839);
		}
		internal static global::MonoJavaBridge.MethodId _beginTransactionWithListener2840;
		public virtual void beginTransactionWithListener(android.database.sqlite.SQLiteTransactionListener arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._beginTransactionWithListener2840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._beginTransactionWithListener2840, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _endTransaction2841;
		public virtual void endTransaction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._endTransaction2841);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._endTransaction2841);
		}
		internal static global::MonoJavaBridge.MethodId _setTransactionSuccessful2842;
		public virtual void setTransactionSuccessful() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._setTransactionSuccessful2842);
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setTransactionSuccessful2842);
		}
		internal static global::MonoJavaBridge.MethodId _inTransaction2843;
		public virtual bool inTransaction() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._inTransaction2843);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._inTransaction2843);
		}
		internal static global::MonoJavaBridge.MethodId _isDbLockedByCurrentThread2844;
		public virtual bool isDbLockedByCurrentThread() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._isDbLockedByCurrentThread2844);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._isDbLockedByCurrentThread2844);
		}
		internal static global::MonoJavaBridge.MethodId _isDbLockedByOtherThreads2845;
		public virtual bool isDbLockedByOtherThreads() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._isDbLockedByOtherThreads2845);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._isDbLockedByOtherThreads2845);
		}
		internal static global::MonoJavaBridge.MethodId _yieldIfContended2846;
		public virtual bool yieldIfContended() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._yieldIfContended2846);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._yieldIfContended2846);
		}
		internal static global::MonoJavaBridge.MethodId _yieldIfContendedSafely2847;
		public virtual bool yieldIfContendedSafely(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely2847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely2847, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _yieldIfContendedSafely2848;
		public virtual bool yieldIfContendedSafely() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely2848);
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely2848);
		}
		public new global::java.util.Map SyncedTables
		{
			get
			{
				return getSyncedTables();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getSyncedTables2849;
		public virtual global::java.util.Map getSyncedTables() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._getSyncedTables2849)) as java.util.Map;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::java.util.Map>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._getSyncedTables2849)) as java.util.Map;
		}
		internal static global::MonoJavaBridge.MethodId _openDatabase2850;
		public static global::android.database.sqlite.SQLiteDatabase openDatabase(java.lang.String arg0, android.database.sqlite.SQLiteDatabase.CursorFactory arg1, int arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._openDatabase2850, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2))) as android.database.sqlite.SQLiteDatabase;
		}
		public new long MaximumSize
		{
			get
			{
				return getMaximumSize();
			}
		}
		internal static global::MonoJavaBridge.MethodId _getMaximumSize2851;
		public virtual long getMaximumSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._getMaximumSize2851);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._getMaximumSize2851);
		}
		internal static global::MonoJavaBridge.MethodId _setMaximumSize2852;
		public virtual long setMaximumSize(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._setMaximumSize2852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setMaximumSize2852, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		internal static global::MonoJavaBridge.MethodId _getPageSize2853;
		public virtual long getPageSize() 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._getPageSize2853);
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._getPageSize2853);
		}
		internal static global::MonoJavaBridge.MethodId _setPageSize2854;
		public virtual void setPageSize(long arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._setPageSize2854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setPageSize2854, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _markTableSyncable2855;
		public virtual void markTableSyncable(java.lang.String arg0, java.lang.String arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._markTableSyncable2855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._markTableSyncable2855, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _markTableSyncable2856;
		public virtual void markTableSyncable(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._markTableSyncable2856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._markTableSyncable2856, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _findEditTable2857;
		public static global::java.lang.String findEditTable(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallStaticObjectMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._findEditTable2857, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as java.lang.String;
		}
		internal static global::MonoJavaBridge.MethodId _compileStatement2858;
		public virtual global::android.database.sqlite.SQLiteStatement compileStatement(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._compileStatement2858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.sqlite.SQLiteStatement;
			else
				return global::MonoJavaBridge.JavaBridge.WrapJavaObject(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._compileStatement2858, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0))) as android.database.sqlite.SQLiteStatement;
		}
		internal static global::MonoJavaBridge.MethodId _queryWithFactory2859;
		public virtual global::android.database.Cursor queryWithFactory(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, bool arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String[] arg5, java.lang.String arg6, java.lang.String arg7, java.lang.String arg8, java.lang.String arg9) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._queryWithFactory2859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._queryWithFactory2859, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg5), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg6), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg7), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg8), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg9))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _rawQuery2860;
		public virtual global::android.database.Cursor rawQuery(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._rawQuery2860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._rawQuery2860, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _rawQueryWithFactory2861;
		public virtual global::android.database.Cursor rawQueryWithFactory(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._rawQueryWithFactory2861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.database.Cursor;
			else
				return global::MonoJavaBridge.JavaBridge.WrapIJavaObject<global::android.database.Cursor>(@__env.CallNonVirtualObjectMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._rawQueryWithFactory2861, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3))) as android.database.Cursor;
		}
		internal static global::MonoJavaBridge.MethodId _insertOrThrow2862;
		public virtual long insertOrThrow(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._insertOrThrow2862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._insertOrThrow2862, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _replaceOrThrow2863;
		public virtual long replaceOrThrow(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._replaceOrThrow2863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._replaceOrThrow2863, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		internal static global::MonoJavaBridge.MethodId _insertWithOnConflict2864;
		public virtual long insertWithOnConflict(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2, int arg3) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._insertWithOnConflict2864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
			else
				return @__env.CallNonVirtualLongMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._insertWithOnConflict2864, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		internal static global::MonoJavaBridge.MethodId _updateWithOnConflict2865;
		public virtual int updateWithOnConflict(java.lang.String arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3, int arg4) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._updateWithOnConflict2865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
			else
				return @__env.CallNonVirtualIntMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._updateWithOnConflict2865, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg4));
		}
		internal static global::MonoJavaBridge.MethodId _execSQL2866;
		public virtual void execSQL(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._execSQL2866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._execSQL2866, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		internal static global::MonoJavaBridge.MethodId _execSQL2867;
		public virtual void execSQL(java.lang.String arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._execSQL2867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._execSQL2867, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		internal static global::MonoJavaBridge.MethodId _needUpgrade2868;
		public virtual bool needUpgrade(int arg0) 
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase._needUpgrade2868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this.JvmHandle, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._needUpgrade2868, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
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
		private static void InitJNI()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::android.database.sqlite.SQLiteDatabase.staticClass = @__env.NewGlobalRef(@__env.FindClass("android/database/sqlite/SQLiteDatabase"));
			global::android.database.sqlite.SQLiteDatabase._finalize2818 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "finalize", "()V");
			global::android.database.sqlite.SQLiteDatabase._replace2819 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "replace", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J");
			global::android.database.sqlite.SQLiteDatabase._close2820 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "close", "()V");
			global::android.database.sqlite.SQLiteDatabase._delete2821 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "delete", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.database.sqlite.SQLiteDatabase._insert2822 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "insert", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J");
			global::android.database.sqlite.SQLiteDatabase._isReadOnly2823 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "isReadOnly", "()Z");
			global::android.database.sqlite.SQLiteDatabase._getPath2824 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "getPath", "()Ljava/lang/String;");
			global::android.database.sqlite.SQLiteDatabase._query2825 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "query", "(ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._query2826 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._query2827 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._create2828 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "create", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteDatabase._isOpen2829 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "isOpen", "()Z");
			global::android.database.sqlite.SQLiteDatabase._update2830 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "update", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.database.sqlite.SQLiteDatabase._getVersion2831 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "getVersion", "()I");
			global::android.database.sqlite.SQLiteDatabase._setVersion2832 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "setVersion", "(I)V");
			global::android.database.sqlite.SQLiteDatabase._setLocale2833 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "setLocale", "(Ljava/util/Locale;)V");
			global::android.database.sqlite.SQLiteDatabase._openOrCreateDatabase2834 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteDatabase._openOrCreateDatabase2835 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "openOrCreateDatabase", "(Ljava/io/File;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteDatabase._onAllReferencesReleased2836 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "onAllReferencesReleased", "()V");
			global::android.database.sqlite.SQLiteDatabase._releaseMemory2837 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "releaseMemory", "()I");
			global::android.database.sqlite.SQLiteDatabase._setLockingEnabled2838 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "setLockingEnabled", "(Z)V");
			global::android.database.sqlite.SQLiteDatabase._beginTransaction2839 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "beginTransaction", "()V");
			global::android.database.sqlite.SQLiteDatabase._beginTransactionWithListener2840 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "beginTransactionWithListener", "(Landroid/database/sqlite/SQLiteTransactionListener;)V");
			global::android.database.sqlite.SQLiteDatabase._endTransaction2841 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "endTransaction", "()V");
			global::android.database.sqlite.SQLiteDatabase._setTransactionSuccessful2842 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "setTransactionSuccessful", "()V");
			global::android.database.sqlite.SQLiteDatabase._inTransaction2843 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "inTransaction", "()Z");
			global::android.database.sqlite.SQLiteDatabase._isDbLockedByCurrentThread2844 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "isDbLockedByCurrentThread", "()Z");
			global::android.database.sqlite.SQLiteDatabase._isDbLockedByOtherThreads2845 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "isDbLockedByOtherThreads", "()Z");
			global::android.database.sqlite.SQLiteDatabase._yieldIfContended2846 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "yieldIfContended", "()Z");
			global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely2847 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "yieldIfContendedSafely", "(J)Z");
			global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely2848 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "yieldIfContendedSafely", "()Z");
			global::android.database.sqlite.SQLiteDatabase._getSyncedTables2849 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "getSyncedTables", "()Ljava/util/Map;");
			global::android.database.sqlite.SQLiteDatabase._openDatabase2850 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "openDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;I)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteDatabase._getMaximumSize2851 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "getMaximumSize", "()J");
			global::android.database.sqlite.SQLiteDatabase._setMaximumSize2852 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "setMaximumSize", "(J)J");
			global::android.database.sqlite.SQLiteDatabase._getPageSize2853 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "getPageSize", "()J");
			global::android.database.sqlite.SQLiteDatabase._setPageSize2854 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "setPageSize", "(J)V");
			global::android.database.sqlite.SQLiteDatabase._markTableSyncable2855 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "markTableSyncable", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteDatabase._markTableSyncable2856 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "markTableSyncable", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteDatabase._findEditTable2857 = @__env.GetStaticMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "findEditTable", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.sqlite.SQLiteDatabase._compileStatement2858 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "compileStatement", "(Ljava/lang/String;)Landroid/database/sqlite/SQLiteStatement;");
			global::android.database.sqlite.SQLiteDatabase._queryWithFactory2859 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "queryWithFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._rawQuery2860 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "rawQuery", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._rawQueryWithFactory2861 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "rawQueryWithFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._insertOrThrow2862 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "insertOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J");
			global::android.database.sqlite.SQLiteDatabase._replaceOrThrow2863 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "replaceOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J");
			global::android.database.sqlite.SQLiteDatabase._insertWithOnConflict2864 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "insertWithOnConflict", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;I)J");
			global::android.database.sqlite.SQLiteDatabase._updateWithOnConflict2865 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "updateWithOnConflict", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;I)I");
			global::android.database.sqlite.SQLiteDatabase._execSQL2866 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "execSQL", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			global::android.database.sqlite.SQLiteDatabase._execSQL2867 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "execSQL", "(Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteDatabase._needUpgrade2868 = @__env.GetMethodIDNoThrow(global::android.database.sqlite.SQLiteDatabase.staticClass, "needUpgrade", "(I)Z");
		}
	}
}
