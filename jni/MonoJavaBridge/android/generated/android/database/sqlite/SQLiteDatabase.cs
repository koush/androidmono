namespace android.database.sqlite
{
	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public class SQLiteDatabase : android.database.sqlite.SQLiteClosable
	{
		internal new static global::java.lang.Class staticClass;
		static SQLiteDatabase()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.sqlite.SQLiteDatabase), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.database.sqlite.SQLiteDatabase(@__env);
			}
		}
		protected SQLiteDatabase(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
		public interface CursorFactory 
		{
			global::android.database.Cursor newCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3);
		}

		public partial class CursorFactory_
		{
			public static global::java.lang.Class _class
			{
				get { return __CursorFactory.staticClass; }
			}
		}

		[global::net.sf.jni4net.attributes.JavaClassAttribute()]
		public sealed class __CursorFactory : java.lang.Object, CursorFactory
		{
			internal static global::java.lang.Class staticClass;
			static __CursorFactory()
			{
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.sqlite.SQLiteDatabase.__CursorFactory), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
			}
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
			{
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
				{
					return new global::android.database.sqlite.SQLiteDatabase.__CursorFactory(@__env);
				}
			}
			internal __CursorFactory(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
			{
			}
			internal static global::net.sf.jni4net.jni.MethodId _newCursor2648;
			 global::android.database.Cursor android.database.sqlite.SQLiteDatabase.CursorFactory.newCursor(android.database.sqlite.SQLiteDatabase arg0, android.database.sqlite.SQLiteCursorDriver arg1, java.lang.String arg2, android.database.sqlite.SQLiteQuery arg3) 
			{
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
				if (!IsClrObject)
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase.__CursorFactory._newCursor2648, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
				else
					return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase.__CursorFactory.staticClass, global::android.database.sqlite.SQLiteDatabase.__CursorFactory._newCursor2648, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
			}
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
			{
				global::android.database.sqlite.SQLiteDatabase.__CursorFactory.staticClass = @__class;
				global::android.database.sqlite.SQLiteDatabase.__CursorFactory._newCursor2648 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.__CursorFactory.staticClass, "android.database.sqlite.SQLiteDatabase.CursorFactory.newCursor", "(Landroid/database/sqlite/SQLiteDatabase;Landroid/database/sqlite/SQLiteCursorDriver;Ljava/lang/String;Landroid/database/sqlite/SQLiteQuery;)Landroid/database/Cursor;");
			}
		}
		internal static global::net.sf.jni4net.jni.MethodId _replace2649;
		public virtual long replace(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase._replace2649, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._replace2649, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close2650;
		public virtual void close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase._close2650);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._close2650);
		}
		internal static global::net.sf.jni4net.jni.MethodId _delete2651;
		public virtual int delete(java.lang.String arg0, java.lang.String arg1, java.lang.String[] arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.sqlite.SQLiteDatabase._delete2651, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._delete2651, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _insert2652;
		public virtual long insert(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase._insert2652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._insert2652, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isReadOnly2653;
		public virtual bool isReadOnly() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase._isReadOnly2653);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._isReadOnly2653);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPath2654;
		public virtual global::java.lang.String getPath() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase._getPath2654));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._getPath2654));
		}
		internal static global::net.sf.jni4net.jni.MethodId _query2655;
		public virtual global::android.database.Cursor query(bool arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3, java.lang.String[] arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7, java.lang.String arg8) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase._query2655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._query2655, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _query2656;
		public virtual global::android.database.Cursor query(java.lang.String arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6, java.lang.String arg7) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase._query2656, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._query2656, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _query2657;
		public virtual global::android.database.Cursor query(java.lang.String arg0, java.lang.String[] arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String arg5, java.lang.String arg6) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase._query2657, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._query2657, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _create2658;
		public static global::android.database.sqlite.SQLiteDatabase create(android.database.sqlite.SQLiteDatabase.CursorFactory arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallStaticObjectMethodPtr(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._create2658, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isOpen2659;
		public virtual bool isOpen() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase._isOpen2659);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._isOpen2659);
		}
		internal static global::net.sf.jni4net.jni.MethodId _update2660;
		public virtual int update(java.lang.String arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.sqlite.SQLiteDatabase._update2660, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._update2660, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getVersion2661;
		public virtual int getVersion() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.sqlite.SQLiteDatabase._getVersion2661);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._getVersion2661);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setVersion2662;
		public virtual void setVersion(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase._setVersion2662, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setVersion2662, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLocale2663;
		public virtual void setLocale(java.util.Locale arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase._setLocale2663, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setLocale2663, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openOrCreateDatabase2664;
		public static global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.lang.String arg0, android.database.sqlite.SQLiteDatabase.CursorFactory arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallStaticObjectMethodPtr(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._openOrCreateDatabase2664, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openOrCreateDatabase2665;
		public static global::android.database.sqlite.SQLiteDatabase openOrCreateDatabase(java.io.File arg0, android.database.sqlite.SQLiteDatabase.CursorFactory arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallStaticObjectMethodPtr(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._openOrCreateDatabase2665, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onAllReferencesReleased2666;
		protected override void onAllReferencesReleased() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase._onAllReferencesReleased2666);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._onAllReferencesReleased2666);
		}
		internal static global::net.sf.jni4net.jni.MethodId _releaseMemory2667;
		public static int releaseMemory() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return @__env.CallStaticIntMethod(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._releaseMemory2667);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setLockingEnabled2668;
		public virtual void setLockingEnabled(bool arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase._setLockingEnabled2668, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setLockingEnabled2668, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _beginTransaction2669;
		public virtual void beginTransaction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase._beginTransaction2669);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._beginTransaction2669);
		}
		internal static global::net.sf.jni4net.jni.MethodId _beginTransactionWithListener2670;
		public virtual void beginTransactionWithListener(android.database.sqlite.SQLiteTransactionListener arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase._beginTransactionWithListener2670, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._beginTransactionWithListener2670, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _endTransaction2671;
		public virtual void endTransaction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase._endTransaction2671);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._endTransaction2671);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setTransactionSuccessful2672;
		public virtual void setTransactionSuccessful() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase._setTransactionSuccessful2672);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setTransactionSuccessful2672);
		}
		internal static global::net.sf.jni4net.jni.MethodId _inTransaction2673;
		public virtual bool inTransaction() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase._inTransaction2673);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._inTransaction2673);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDbLockedByCurrentThread2674;
		public virtual bool isDbLockedByCurrentThread() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase._isDbLockedByCurrentThread2674);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._isDbLockedByCurrentThread2674);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isDbLockedByOtherThreads2675;
		public virtual bool isDbLockedByOtherThreads() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase._isDbLockedByOtherThreads2675);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._isDbLockedByOtherThreads2675);
		}
		internal static global::net.sf.jni4net.jni.MethodId _yieldIfContended2676;
		public virtual bool yieldIfContended() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase._yieldIfContended2676);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._yieldIfContended2676);
		}
		internal static global::net.sf.jni4net.jni.MethodId _yieldIfContendedSafely2677;
		public virtual bool yieldIfContendedSafely(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely2677, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely2677, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _yieldIfContendedSafely2678;
		public virtual bool yieldIfContendedSafely() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely2678);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely2678);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getSyncedTables2679;
		public virtual global::java.util.Map getSyncedTables() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase._getSyncedTables2679));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.util.Map>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._getSyncedTables2679));
		}
		internal static global::net.sf.jni4net.jni.MethodId _openDatabase2680;
		public static global::android.database.sqlite.SQLiteDatabase openDatabase(java.lang.String arg0, android.database.sqlite.SQLiteDatabase.CursorFactory arg1, int arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteDatabase>(@__env, @__env.CallStaticObjectMethodPtr(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._openDatabase2680, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg1), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg2)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getMaximumSize2681;
		public virtual long getMaximumSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase._getMaximumSize2681);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._getMaximumSize2681);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setMaximumSize2682;
		public virtual long setMaximumSize(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase._setMaximumSize2682, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setMaximumSize2682, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPageSize2683;
		public virtual long getPageSize() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase._getPageSize2683);
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._getPageSize2683);
		}
		internal static global::net.sf.jni4net.jni.MethodId _setPageSize2684;
		public virtual void setPageSize(long arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase._setPageSize2684, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._setPageSize2684, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _markTableSyncable2685;
		public virtual void markTableSyncable(java.lang.String arg0, java.lang.String arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase._markTableSyncable2685, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._markTableSyncable2685, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _markTableSyncable2686;
		public virtual void markTableSyncable(java.lang.String arg0, java.lang.String arg1, java.lang.String arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase._markTableSyncable2686, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._markTableSyncable2686, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _findEditTable2687;
		public static global::java.lang.String findEditTable(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallStaticObjectMethodPtr(android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._findEditTable2687, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _compileStatement2688;
		public virtual global::android.database.sqlite.SQLiteStatement compileStatement(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteStatement>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase._compileStatement2688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.sqlite.SQLiteStatement>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._compileStatement2688, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _queryWithFactory2689;
		public virtual global::android.database.Cursor queryWithFactory(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, bool arg1, java.lang.String arg2, java.lang.String[] arg3, java.lang.String arg4, java.lang.String[] arg5, java.lang.String arg6, java.lang.String arg7, java.lang.String arg8, java.lang.String arg9) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase._queryWithFactory2689, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg9)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._queryWithFactory2689, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg4), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg5), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg6), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg7), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg8), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg9)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rawQuery2690;
		public virtual global::android.database.Cursor rawQuery(java.lang.String arg0, java.lang.String[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase._rawQuery2690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._rawQuery2690, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg1)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _rawQueryWithFactory2691;
		public virtual global::android.database.Cursor rawQueryWithFactory(android.database.sqlite.SQLiteDatabase.CursorFactory arg0, java.lang.String arg1, java.lang.String[] arg2, java.lang.String arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase._rawQueryWithFactory2691, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
			else
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<android.database.Cursor>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._rawQueryWithFactory2691, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg2), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg3)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _insertOrThrow2692;
		public virtual long insertOrThrow(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase._insertOrThrow2692, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._insertOrThrow2692, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _replaceOrThrow2693;
		public virtual long replaceOrThrow(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase._replaceOrThrow2693, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._replaceOrThrow2693, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2));
		}
		internal static global::net.sf.jni4net.jni.MethodId _insertWithOnConflict2694;
		public virtual long insertWithOnConflict(java.lang.String arg0, java.lang.String arg1, android.content.ContentValues arg2, int arg3) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.sqlite.SQLiteDatabase._insertWithOnConflict2694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._insertWithOnConflict2694, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg3));
		}
		internal static global::net.sf.jni4net.jni.MethodId _updateWithOnConflict2695;
		public virtual int updateWithOnConflict(java.lang.String arg0, android.content.ContentValues arg1, java.lang.String arg2, java.lang.String[] arg3, int arg4) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.sqlite.SQLiteDatabase._updateWithOnConflict2695, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._updateWithOnConflict2695, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg2), global::net.sf.jni4net.utils.Convertor.ParArrayStrongCp2J(@__env, arg3), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg4));
		}
		internal static global::net.sf.jni4net.jni.MethodId _execSQL2696;
		public virtual void execSQL(java.lang.String arg0, java.lang.Object[] arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase._execSQL2696, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._execSQL2696, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParArrayFullC2J<java.lang.Object[], java.lang.Object>(@__env, arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _execSQL2697;
		public virtual void execSQL(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.sqlite.SQLiteDatabase._execSQL2697, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._execSQL2697, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _needUpgrade2698;
		public virtual bool needUpgrade(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase._needUpgrade2698, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.sqlite.SQLiteDatabase.staticClass, global::android.database.sqlite.SQLiteDatabase._needUpgrade2698, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
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
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.sqlite.SQLiteDatabase.staticClass = @__class;
			global::android.database.sqlite.SQLiteDatabase._replace2649 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "replace", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J");
			global::android.database.sqlite.SQLiteDatabase._close2650 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "close", "()V");
			global::android.database.sqlite.SQLiteDatabase._delete2651 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "delete", "(Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.database.sqlite.SQLiteDatabase._insert2652 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "insert", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J");
			global::android.database.sqlite.SQLiteDatabase._isReadOnly2653 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "isReadOnly", "()Z");
			global::android.database.sqlite.SQLiteDatabase._getPath2654 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "getPath", "()Ljava/lang/String;");
			global::android.database.sqlite.SQLiteDatabase._query2655 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "query", "(ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._query2656 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._query2657 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "query", "(Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._create2658 = @__env.GetStaticMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "create", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteDatabase._isOpen2659 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "isOpen", "()Z");
			global::android.database.sqlite.SQLiteDatabase._update2660 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "update", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;)I");
			global::android.database.sqlite.SQLiteDatabase._getVersion2661 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "getVersion", "()I");
			global::android.database.sqlite.SQLiteDatabase._setVersion2662 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "setVersion", "(I)V");
			global::android.database.sqlite.SQLiteDatabase._setLocale2663 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "setLocale", "(Ljava/util/Locale;)V");
			global::android.database.sqlite.SQLiteDatabase._openOrCreateDatabase2664 = @__env.GetStaticMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "openOrCreateDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteDatabase._openOrCreateDatabase2665 = @__env.GetStaticMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "openOrCreateDatabase", "(Ljava/io/File;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteDatabase._onAllReferencesReleased2666 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "onAllReferencesReleased", "()V");
			global::android.database.sqlite.SQLiteDatabase._releaseMemory2667 = @__env.GetStaticMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "releaseMemory", "()I");
			global::android.database.sqlite.SQLiteDatabase._setLockingEnabled2668 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "setLockingEnabled", "(Z)V");
			global::android.database.sqlite.SQLiteDatabase._beginTransaction2669 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "beginTransaction", "()V");
			global::android.database.sqlite.SQLiteDatabase._beginTransactionWithListener2670 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "beginTransactionWithListener", "(Landroid/database/sqlite/SQLiteTransactionListener;)V");
			global::android.database.sqlite.SQLiteDatabase._endTransaction2671 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "endTransaction", "()V");
			global::android.database.sqlite.SQLiteDatabase._setTransactionSuccessful2672 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "setTransactionSuccessful", "()V");
			global::android.database.sqlite.SQLiteDatabase._inTransaction2673 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "inTransaction", "()Z");
			global::android.database.sqlite.SQLiteDatabase._isDbLockedByCurrentThread2674 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "isDbLockedByCurrentThread", "()Z");
			global::android.database.sqlite.SQLiteDatabase._isDbLockedByOtherThreads2675 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "isDbLockedByOtherThreads", "()Z");
			global::android.database.sqlite.SQLiteDatabase._yieldIfContended2676 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "yieldIfContended", "()Z");
			global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely2677 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "yieldIfContendedSafely", "(J)Z");
			global::android.database.sqlite.SQLiteDatabase._yieldIfContendedSafely2678 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "yieldIfContendedSafely", "()Z");
			global::android.database.sqlite.SQLiteDatabase._getSyncedTables2679 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "getSyncedTables", "()Ljava/util/Map;");
			global::android.database.sqlite.SQLiteDatabase._openDatabase2680 = @__env.GetStaticMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "openDatabase", "(Ljava/lang/String;Landroid/database/sqlite/SQLiteDatabase$CursorFactory;I)Landroid/database/sqlite/SQLiteDatabase;");
			global::android.database.sqlite.SQLiteDatabase._getMaximumSize2681 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "getMaximumSize", "()J");
			global::android.database.sqlite.SQLiteDatabase._setMaximumSize2682 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "setMaximumSize", "(J)J");
			global::android.database.sqlite.SQLiteDatabase._getPageSize2683 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "getPageSize", "()J");
			global::android.database.sqlite.SQLiteDatabase._setPageSize2684 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "setPageSize", "(J)V");
			global::android.database.sqlite.SQLiteDatabase._markTableSyncable2685 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "markTableSyncable", "(Ljava/lang/String;Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteDatabase._markTableSyncable2686 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "markTableSyncable", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteDatabase._findEditTable2687 = @__env.GetStaticMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "findEditTable", "(Ljava/lang/String;)Ljava/lang/String;");
			global::android.database.sqlite.SQLiteDatabase._compileStatement2688 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "compileStatement", "(Ljava/lang/String;)Landroid/database/sqlite/SQLiteStatement;");
			global::android.database.sqlite.SQLiteDatabase._queryWithFactory2689 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "queryWithFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;ZLjava/lang/String;[Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._rawQuery2690 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "rawQuery", "(Ljava/lang/String;[Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._rawQueryWithFactory2691 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "rawQueryWithFactory", "(Landroid/database/sqlite/SQLiteDatabase$CursorFactory;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;)Landroid/database/Cursor;");
			global::android.database.sqlite.SQLiteDatabase._insertOrThrow2692 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "insertOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J");
			global::android.database.sqlite.SQLiteDatabase._replaceOrThrow2693 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "replaceOrThrow", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;)J");
			global::android.database.sqlite.SQLiteDatabase._insertWithOnConflict2694 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "insertWithOnConflict", "(Ljava/lang/String;Ljava/lang/String;Landroid/content/ContentValues;I)J");
			global::android.database.sqlite.SQLiteDatabase._updateWithOnConflict2695 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "updateWithOnConflict", "(Ljava/lang/String;Landroid/content/ContentValues;Ljava/lang/String;[Ljava/lang/String;I)I");
			global::android.database.sqlite.SQLiteDatabase._execSQL2696 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "execSQL", "(Ljava/lang/String;[Ljava/lang/Object;)V");
			global::android.database.sqlite.SQLiteDatabase._execSQL2697 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "execSQL", "(Ljava/lang/String;)V");
			global::android.database.sqlite.SQLiteDatabase._needUpgrade2698 = @__env.GetMethodID(global::android.database.sqlite.SQLiteDatabase.staticClass, "needUpgrade", "(I)Z");
		}
	}
}
