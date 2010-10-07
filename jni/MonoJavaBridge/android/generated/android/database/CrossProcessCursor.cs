namespace android.database
{
	[global::net.sf.jni4net.attributes.JavaInterfaceAttribute()]
	public interface CrossProcessCursor : Cursor
	{
		global::android.database.CursorWindow getWindow();
		bool onMove(int arg0, int arg1);
		void fillWindow(int arg0, android.database.CursorWindow arg1);
	}

	public partial class CrossProcessCursor_
	{
		public static global::java.lang.Class _class
		{
			get { return __CrossProcessCursor.staticClass; }
		}
	}

	[global::net.sf.jni4net.attributes.JavaClassAttribute()]
	public sealed class __CrossProcessCursor : java.lang.Object, CrossProcessCursor
	{
		internal static global::java.lang.Class staticClass;
		static __CrossProcessCursor()
		{
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.__CrossProcessCursor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv);
		}
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper
		{
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env)
			{
				return new global::android.database.__CrossProcessCursor(@__env);
			}
		}
		internal __CrossProcessCursor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env)
		{
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWindow2354;
		 global::android.database.CursorWindow android.database.CrossProcessCursor.getWindow() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__CrossProcessCursor._getWindow2354));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getWindow2354));
		}
		internal static global::net.sf.jni4net.jni.MethodId _onMove2355;
		 bool android.database.CrossProcessCursor.onMove(int arg0, int arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._onMove2355, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._onMove2355, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _fillWindow2356;
		 void android.database.CrossProcessCursor.fillWindow(int arg0, android.database.CursorWindow arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._fillWindow2356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._fillWindow2356, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getShort2357;
		 short android.database.Cursor.getShort(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallShortMethod(this, global::android.database.__CrossProcessCursor._getShort2357, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualShortMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getShort2357, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getInt2358;
		 int android.database.Cursor.getInt(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.__CrossProcessCursor._getInt2358, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getInt2358, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getLong2359;
		 long android.database.Cursor.getLong(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallLongMethod(this, global::android.database.__CrossProcessCursor._getLong2359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualLongMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getLong2359, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2360;
		 float android.database.Cursor.getFloat(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallFloatMethod(this, global::android.database.__CrossProcessCursor._getFloat2360, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualFloatMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getFloat2360, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2361;
		 double android.database.Cursor.getDouble(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallDoubleMethod(this, global::android.database.__CrossProcessCursor._getDouble2361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualDoubleMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getDouble2361, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _close2362;
		 void android.database.Cursor.close() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._close2362);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._close2362);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getString2363;
		 global::java.lang.String android.database.Cursor.getString(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__CrossProcessCursor._getString2363, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getString2363, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isFirst2364;
		 bool android.database.Cursor.isFirst() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._isFirst2364);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._isFirst2364);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isClosed2365;
		 bool android.database.Cursor.isClosed() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._isClosed2365);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._isClosed2365);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getPosition2366;
		 int android.database.Cursor.getPosition() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.__CrossProcessCursor._getPosition2366);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getPosition2366);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getExtras2367;
		 global::android.os.Bundle android.database.Cursor.getExtras() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__CrossProcessCursor._getExtras2367));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getExtras2367));
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerContentObserver2368;
		 void android.database.Cursor.registerContentObserver(android.database.ContentObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._registerContentObserver2368, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._registerContentObserver2368, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterContentObserver2369;
		 void android.database.Cursor.unregisterContentObserver(android.database.ContentObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._unregisterContentObserver2369, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._unregisterContentObserver2369, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getCount2370;
		 int android.database.Cursor.getCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.__CrossProcessCursor._getCount2370);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getCount2370);
		}
		internal static global::net.sf.jni4net.jni.MethodId _move2371;
		 bool android.database.Cursor.move(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._move2371, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._move2371, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToPosition2372;
		 bool android.database.Cursor.moveToPosition(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._moveToPosition2372, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._moveToPosition2372, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToFirst2373;
		 bool android.database.Cursor.moveToFirst() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._moveToFirst2373);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._moveToFirst2373);
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToLast2374;
		 bool android.database.Cursor.moveToLast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._moveToLast2374);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._moveToLast2374);
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToNext2375;
		 bool android.database.Cursor.moveToNext() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._moveToNext2375);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._moveToNext2375);
		}
		internal static global::net.sf.jni4net.jni.MethodId _moveToPrevious2376;
		 bool android.database.Cursor.moveToPrevious() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._moveToPrevious2376);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._moveToPrevious2376);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isLast2377;
		 bool android.database.Cursor.isLast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._isLast2377);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._isLast2377);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isBeforeFirst2378;
		 bool android.database.Cursor.isBeforeFirst() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._isBeforeFirst2378);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._isBeforeFirst2378);
		}
		internal static global::net.sf.jni4net.jni.MethodId _isAfterLast2379;
		 bool android.database.Cursor.isAfterLast() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._isAfterLast2379);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._isAfterLast2379);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndex2380;
		 int android.database.Cursor.getColumnIndex(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.__CrossProcessCursor._getColumnIndex2380, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getColumnIndex2380, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndexOrThrow2381;
		 int android.database.Cursor.getColumnIndexOrThrow(java.lang.String arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.__CrossProcessCursor._getColumnIndexOrThrow2381, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getColumnIndexOrThrow2381, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnName2382;
		 global::java.lang.String android.database.Cursor.getColumnName(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__CrossProcessCursor._getColumnName2382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getColumnName2382, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNames2383;
		 global::java.lang.String[] android.database.Cursor.getColumnNames() 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__CrossProcessCursor._getColumnNames2383));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getColumnNames2383));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getColumnCount2384;
		 int android.database.Cursor.getColumnCount() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallIntMethod(this, global::android.database.__CrossProcessCursor._getColumnCount2384);
			else
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getColumnCount2384);
		}
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2385;
		 byte[] android.database.Cursor.getBlob(int arg0) 
		{
			if (!IsClrObject)
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__CrossProcessCursor._getBlob2385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
			else
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getBlob2385, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)));
		}
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2386;
		 void android.database.Cursor.copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._copyStringToBuffer2386, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._copyStringToBuffer2386, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _isNull2387;
		 bool android.database.Cursor.isNull(int arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._isNull2387, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._isNull2387, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _deactivate2388;
		 void android.database.Cursor.deactivate() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._deactivate2388);
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._deactivate2388);
		}
		internal static global::net.sf.jni4net.jni.MethodId _requery2389;
		 bool android.database.Cursor.requery() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._requery2389);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._requery2389);
		}
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver2390;
		 void android.database.Cursor.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._registerDataSetObserver2390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._registerDataSetObserver2390, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver2391;
		 void android.database.Cursor.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._unregisterDataSetObserver2391, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._unregisterDataSetObserver2391, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0));
		}
		internal static global::net.sf.jni4net.jni.MethodId _setNotificationUri2392;
		 void android.database.Cursor.setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._setNotificationUri2392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
			else
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._setNotificationUri2392, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1));
		}
		internal static global::net.sf.jni4net.jni.MethodId _getWantsAllOnMoveCalls2393;
		 bool android.database.Cursor.getWantsAllOnMoveCalls() 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._getWantsAllOnMoveCalls2393);
			else
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getWantsAllOnMoveCalls2393);
		}
		internal static global::net.sf.jni4net.jni.MethodId _respond2394;
		 global::android.os.Bundle android.database.Cursor.respond(android.os.Bundle arg0) 
		{
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv;
			if (!IsClrObject)
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__CrossProcessCursor._respond2394, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
			else
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._respond2394, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)));
		}
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class)
		{
			global::android.database.__CrossProcessCursor.staticClass = @__class;
			global::android.database.__CrossProcessCursor._getWindow2354 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.CrossProcessCursor.getWindow", "()Landroid/database/CursorWindow;");
			global::android.database.__CrossProcessCursor._onMove2355 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.CrossProcessCursor.onMove", "(II)Z");
			global::android.database.__CrossProcessCursor._fillWindow2356 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.CrossProcessCursor.fillWindow", "(ILandroid/database/CursorWindow;)V");
			global::android.database.__CrossProcessCursor._getShort2357 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getShort", "(I)S");
			global::android.database.__CrossProcessCursor._getInt2358 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getInt", "(I)I");
			global::android.database.__CrossProcessCursor._getLong2359 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getLong", "(I)J");
			global::android.database.__CrossProcessCursor._getFloat2360 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getFloat", "(I)F");
			global::android.database.__CrossProcessCursor._getDouble2361 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getDouble", "(I)D");
			global::android.database.__CrossProcessCursor._close2362 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.close", "()V");
			global::android.database.__CrossProcessCursor._getString2363 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getString", "(I)Ljava/lang/String;");
			global::android.database.__CrossProcessCursor._isFirst2364 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.isFirst", "()Z");
			global::android.database.__CrossProcessCursor._isClosed2365 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.isClosed", "()Z");
			global::android.database.__CrossProcessCursor._getPosition2366 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getPosition", "()I");
			global::android.database.__CrossProcessCursor._getExtras2367 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getExtras", "()Landroid/os/Bundle;");
			global::android.database.__CrossProcessCursor._registerContentObserver2368 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.registerContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.__CrossProcessCursor._unregisterContentObserver2369 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.unregisterContentObserver", "(Landroid/database/ContentObserver;)V");
			global::android.database.__CrossProcessCursor._getCount2370 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getCount", "()I");
			global::android.database.__CrossProcessCursor._move2371 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.move", "(I)Z");
			global::android.database.__CrossProcessCursor._moveToPosition2372 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.moveToPosition", "(I)Z");
			global::android.database.__CrossProcessCursor._moveToFirst2373 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.moveToFirst", "()Z");
			global::android.database.__CrossProcessCursor._moveToLast2374 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.moveToLast", "()Z");
			global::android.database.__CrossProcessCursor._moveToNext2375 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.moveToNext", "()Z");
			global::android.database.__CrossProcessCursor._moveToPrevious2376 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.moveToPrevious", "()Z");
			global::android.database.__CrossProcessCursor._isLast2377 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.isLast", "()Z");
			global::android.database.__CrossProcessCursor._isBeforeFirst2378 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.isBeforeFirst", "()Z");
			global::android.database.__CrossProcessCursor._isAfterLast2379 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.isAfterLast", "()Z");
			global::android.database.__CrossProcessCursor._getColumnIndex2380 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getColumnIndex", "(Ljava/lang/String;)I");
			global::android.database.__CrossProcessCursor._getColumnIndexOrThrow2381 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getColumnIndexOrThrow", "(Ljava/lang/String;)I");
			global::android.database.__CrossProcessCursor._getColumnName2382 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getColumnName", "(I)Ljava/lang/String;");
			global::android.database.__CrossProcessCursor._getColumnNames2383 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getColumnNames", "()[Ljava/lang/String;");
			global::android.database.__CrossProcessCursor._getColumnCount2384 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getColumnCount", "()I");
			global::android.database.__CrossProcessCursor._getBlob2385 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getBlob", "(I)[B");
			global::android.database.__CrossProcessCursor._copyStringToBuffer2386 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V");
			global::android.database.__CrossProcessCursor._isNull2387 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.isNull", "(I)Z");
			global::android.database.__CrossProcessCursor._deactivate2388 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.deactivate", "()V");
			global::android.database.__CrossProcessCursor._requery2389 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.requery", "()Z");
			global::android.database.__CrossProcessCursor._registerDataSetObserver2390 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.registerDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.__CrossProcessCursor._unregisterDataSetObserver2391 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V");
			global::android.database.__CrossProcessCursor._setNotificationUri2392 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V");
			global::android.database.__CrossProcessCursor._getWantsAllOnMoveCalls2393 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getWantsAllOnMoveCalls", "()Z");
			global::android.database.__CrossProcessCursor._respond2394 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;");
		}
	}
}
