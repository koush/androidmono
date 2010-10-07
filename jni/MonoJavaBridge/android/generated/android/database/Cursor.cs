namespace android.database
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface Cursor 
	{
		short getShort(int arg0);
		int getInt(int arg0);
		long getLong(int arg0);
		float getFloat(int arg0);
		double getDouble(int arg0);
		void close();
		global::java.lang.String getString(int arg0);
		bool isFirst();
		bool isClosed();
		int getPosition();
		global::android.os.Bundle getExtras();
		void registerContentObserver(android.database.ContentObserver arg0);
		void unregisterContentObserver(android.database.ContentObserver arg0);
		int getCount();
		bool move(int arg0);
		bool moveToPosition(int arg0);
		bool moveToFirst();
		bool moveToLast();
		bool moveToNext();
		bool moveToPrevious();
		bool isLast();
		bool isBeforeFirst();
		bool isAfterLast();
		int getColumnIndex(java.lang.String arg0);
		int getColumnIndexOrThrow(java.lang.String arg0);
		global::java.lang.String getColumnName(int arg0);
		global::java.lang.String[] getColumnNames();
		int getColumnCount();
		byte[] getBlob(int arg0);
		void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1);
		bool isNull(int arg0);
		void deactivate();
		bool requery();
		void registerDataSetObserver(android.database.DataSetObserver arg0);
		void unregisterDataSetObserver(android.database.DataSetObserver arg0);
		void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1);
		bool getWantsAllOnMoveCalls();
		global::android.os.Bundle respond(android.os.Bundle arg0);
	}

	public partial class Cursor_
	{
		public static global::java.lang.Class _class
		{
			get { return __Cursor.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __Cursor : java.lang.Object, Cursor
	{
		internal static global::java.lang.Class staticClass;
		static __Cursor()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.__Cursor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.database.__Cursor(@__env);
			}
		}
		internal __Cursor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShort2395;
		 short android.database.Cursor.getShort(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this, global::android.database.__Cursor._getShort2395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getShort2395, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInt2396;
		 int android.database.Cursor.getInt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.__Cursor._getInt2396, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getInt2396, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLong2397;
		 long android.database.Cursor.getLong(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.__Cursor._getLong2397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getLong2397, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2398;
		 float android.database.Cursor.getFloat(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.database.__Cursor._getFloat2398, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getFloat2398, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2399;
		 double android.database.Cursor.getDouble(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.database.__Cursor._getDouble2399, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getDouble2399, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close2400;
		 void android.database.Cursor.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__Cursor._close2400);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._close2400);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString2401;
		 global::java.lang.String android.database.Cursor.getString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__Cursor._getString2401, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getString2401, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFirst2402;
		 bool android.database.Cursor.isFirst() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._isFirst2402);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._isFirst2402);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isClosed2403;
		 bool android.database.Cursor.isClosed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._isClosed2403);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._isClosed2403);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPosition2404;
		 int android.database.Cursor.getPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.__Cursor._getPosition2404);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getPosition2404);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExtras2405;
		 global::android.os.Bundle android.database.Cursor.getExtras() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__Cursor._getExtras2405));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getExtras2405));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerContentObserver2406;
		 void android.database.Cursor.registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__Cursor._registerContentObserver2406, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._registerContentObserver2406, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterContentObserver2407;
		 void android.database.Cursor.unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__Cursor._unregisterContentObserver2407, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._unregisterContentObserver2407, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount2408;
		 int android.database.Cursor.getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.__Cursor._getCount2408);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getCount2408);
		}
		internal static global::net.sf.jni4net.jni.MethodId _move2409;
		 bool android.database.Cursor.move(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._move2409, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._move2409, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToPosition2410;
		 bool android.database.Cursor.moveToPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._moveToPosition2410, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._moveToPosition2410, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToFirst2411;
		 bool android.database.Cursor.moveToFirst() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._moveToFirst2411);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._moveToFirst2411);
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToLast2412;
		 bool android.database.Cursor.moveToLast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._moveToLast2412);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._moveToLast2412);
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToNext2413;
		 bool android.database.Cursor.moveToNext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._moveToNext2413);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._moveToNext2413);
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToPrevious2414;
		 bool android.database.Cursor.moveToPrevious() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._moveToPrevious2414);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._moveToPrevious2414);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLast2415;
		 bool android.database.Cursor.isLast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._isLast2415);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._isLast2415);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isBeforeFirst2416;
		 bool android.database.Cursor.isBeforeFirst() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._isBeforeFirst2416);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._isBeforeFirst2416);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAfterLast2417;
		 bool android.database.Cursor.isAfterLast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._isAfterLast2417);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._isAfterLast2417);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndex2418;
		 int android.database.Cursor.getColumnIndex(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.__Cursor._getColumnIndex2418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getColumnIndex2418, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndexOrThrow2419;
		 int android.database.Cursor.getColumnIndexOrThrow(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.__Cursor._getColumnIndexOrThrow2419, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getColumnIndexOrThrow2419, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnName2420;
		 global::java.lang.String android.database.Cursor.getColumnName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__Cursor._getColumnName2420, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getColumnName2420, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNames2421;
		 global::java.lang.String[] android.database.Cursor.getColumnNames() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__Cursor._getColumnNames2421));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getColumnNames2421));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnCount2422;
		 int android.database.Cursor.getColumnCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.__Cursor._getColumnCount2422);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getColumnCount2422);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2423;
		 byte[] android.database.Cursor.getBlob(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__Cursor._getBlob2423, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getBlob2423, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2424;
		 void android.database.Cursor.copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__Cursor._copyStringToBuffer2424, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._copyStringToBuffer2424, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isNull2425;
		 bool android.database.Cursor.isNull(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._isNull2425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._isNull2425, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deactivate2426;
		 void android.database.Cursor.deactivate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__Cursor._deactivate2426);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._deactivate2426);
		}
		internal static global::net.sf.jni4net.jni.MethodId _requery2427;
		 bool android.database.Cursor.requery() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._requery2427);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._requery2427);
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver2428;
		 void android.database.Cursor.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__Cursor._registerDataSetObserver2428, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._registerDataSetObserver2428, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver2429;
		 void android.database.Cursor.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__Cursor._unregisterDataSetObserver2429, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._unregisterDataSetObserver2429, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNotificationUri2430;
		 void android.database.Cursor.setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__Cursor._setNotificationUri2430, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._setNotificationUri2430, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWantsAllOnMoveCalls2431;
		 bool android.database.Cursor.getWantsAllOnMoveCalls() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._getWantsAllOnMoveCalls2431);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getWantsAllOnMoveCalls2431);
		}
		internal static global::net.sf.jni4net.jni.MethodId _respond2432;
		 global::android.os.Bundle android.database.Cursor.respond(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__Cursor._respond2432, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._respond2432, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.__Cursor.staticClass = @__class;
			global::android.database.__Cursor._getShort2395 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getShort", "(I)S");
			global::android.database.__Cursor._getInt2396 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getInt", "(I)I");
			global::android.database.__Cursor._getLong2397 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getLong", "(I)J");
			global::android.database.__Cursor._getFloat2398 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getFloat", "(I)F");
			global::android.database.__Cursor._getDouble2399 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getDouble", "(I)D");
			global::android.database.__Cursor._close2400 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.close", "()V");
			global::android.database.__Cursor._getString2401 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getString", "(I)Ljava/lang/String;");
			global::android.database.__Cursor._isFirst2402 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.isFirst", "()Z");
			global::android.database.__Cursor._isClosed2403 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.isClosed", "()Z");
			global::android.database.__Cursor._getPosition2404 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getPosition", "()I");
			global::android.database.__Cursor._getExtras2405 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getExtras", "()Landroid/os/Bundle;");
			global::android.database.__Cursor._registerContentObserver2406 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.__Cursor._unregisterContentObserver2407 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.__Cursor._getCount2408 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getCount", "()I");
			global::android.database.__Cursor._move2409 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.move", "(I)Z");
			global::android.database.__Cursor._moveToPosition2410 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.moveToPosition", "(I)Z");
			global::android.database.__Cursor._moveToFirst2411 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.moveToFirst", "()Z");
			global::android.database.__Cursor._moveToLast2412 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.moveToLast", "()Z");
			global::android.database.__Cursor._moveToNext2413 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.moveToNext", "()Z");
			global::android.database.__Cursor._moveToPrevious2414 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.moveToPrevious", "()Z");
			global::android.database.__Cursor._isLast2415 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.isLast", "()Z");
			global::android.database.__Cursor._isBeforeFirst2416 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.isBeforeFirst", "()Z");
			global::android.database.__Cursor._isAfterLast2417 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.isAfterLast", "()Z");
			global::android.database.__Cursor._getColumnIndex2418 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getColumnIndex", "(Ljava/lang/String;)I");
			global::android.database.__Cursor._getColumnIndexOrThrow2419 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			global::android.database.__Cursor._getColumnName2420 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getColumnName", "(I)Ljava/lang/String;");
			global::android.database.__Cursor._getColumnNames2421 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getColumnNames", "()[Ljava/lang/String;");
			global::android.database.__Cursor._getColumnCount2422 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getColumnCount", "()I");
			global::android.database.__Cursor._getBlob2423 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getBlob", "(I)[B");
			global::android.database.__Cursor._copyStringToBuffer2424 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.__Cursor._isNull2425 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.isNull", "(I)Z");
			global::android.database.__Cursor._deactivate2426 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.deactivate", "()V");
			global::android.database.__Cursor._requery2427 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.requery", "()Z");
			global::android.database.__Cursor._registerDataSetObserver2428 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.__Cursor._unregisterDataSetObserver2429 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.__Cursor._setNotificationUri2430 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::android.database.__Cursor._getWantsAllOnMoveCalls2431 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getWantsAllOnMoveCalls", "()Z");
			global::android.database.__Cursor._respond2432 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
		}
	}
}
