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
		internal static global::net.sf.jni4net.jni.MethodId _getWindow2173; 
		 global::android.database.CursorWindow android.database.CrossProcessCursor.getWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__CrossProcessCursor._getWindow2173)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getWindow2173)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMove2174; 
		 bool android.database.CrossProcessCursor.onMove(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._onMove2174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._onMove2174, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fillWindow2175; 
		 void android.database.CrossProcessCursor.fillWindow(int arg0, android.database.CursorWindow arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._fillWindow2175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._fillWindow2175, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShort2176; 
		 short android.database.Cursor.getShort(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallShortMethod(this, global::android.database.__CrossProcessCursor._getShort2176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualShortMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getShort2176, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInt2177; 
		 int android.database.Cursor.getInt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.database.__CrossProcessCursor._getInt2177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getInt2177, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLong2178; 
		 long android.database.Cursor.getLong(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallLongMethod(this, global::android.database.__CrossProcessCursor._getLong2178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getLong2178, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2179; 
		 float android.database.Cursor.getFloat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallFloatMethod(this, global::android.database.__CrossProcessCursor._getFloat2179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getFloat2179, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2180; 
		 double android.database.Cursor.getDouble(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallDoubleMethod(this, global::android.database.__CrossProcessCursor._getDouble2180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getDouble2180, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close2181; 
		 void android.database.Cursor.close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._close2181); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._close2181); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString2182; 
		 global::java.lang.String android.database.Cursor.getString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__CrossProcessCursor._getString2182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getString2182, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFirst2183; 
		 bool android.database.Cursor.isFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._isFirst2183); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._isFirst2183); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClosed2184; 
		 bool android.database.Cursor.isClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._isClosed2184); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._isClosed2184); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPosition2185; 
		 int android.database.Cursor.getPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.database.__CrossProcessCursor._getPosition2185); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getPosition2185); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtras2186; 
		 global::android.os.Bundle android.database.Cursor.getExtras() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__CrossProcessCursor._getExtras2186)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getExtras2186)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerContentObserver2187; 
		 void android.database.Cursor.registerContentObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._registerContentObserver2187, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._registerContentObserver2187, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterContentObserver2188; 
		 void android.database.Cursor.unregisterContentObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._unregisterContentObserver2188, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._unregisterContentObserver2188, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount2189; 
		 int android.database.Cursor.getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.database.__CrossProcessCursor._getCount2189); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getCount2189); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _move2190; 
		 bool android.database.Cursor.move(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._move2190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._move2190, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToPosition2191; 
		 bool android.database.Cursor.moveToPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._moveToPosition2191, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._moveToPosition2191, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToFirst2192; 
		 bool android.database.Cursor.moveToFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._moveToFirst2192); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._moveToFirst2192); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToLast2193; 
		 bool android.database.Cursor.moveToLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._moveToLast2193); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._moveToLast2193); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToNext2194; 
		 bool android.database.Cursor.moveToNext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._moveToNext2194); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._moveToNext2194); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToPrevious2195; 
		 bool android.database.Cursor.moveToPrevious() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._moveToPrevious2195); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._moveToPrevious2195); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLast2196; 
		 bool android.database.Cursor.isLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._isLast2196); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._isLast2196); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBeforeFirst2197; 
		 bool android.database.Cursor.isBeforeFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._isBeforeFirst2197); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._isBeforeFirst2197); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAfterLast2198; 
		 bool android.database.Cursor.isAfterLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._isAfterLast2198); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._isAfterLast2198); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndex2199; 
		 int android.database.Cursor.getColumnIndex(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.database.__CrossProcessCursor._getColumnIndex2199, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getColumnIndex2199, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndexOrThrow2200; 
		 int android.database.Cursor.getColumnIndexOrThrow(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.database.__CrossProcessCursor._getColumnIndexOrThrow2200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getColumnIndexOrThrow2200, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnName2201; 
		 global::java.lang.String android.database.Cursor.getColumnName(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__CrossProcessCursor._getColumnName2201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getColumnName2201, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNames2202; 
		 global::java.lang.String[] android.database.Cursor.getColumnNames() 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__CrossProcessCursor._getColumnNames2202)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getColumnNames2202)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnCount2203; 
		 int android.database.Cursor.getColumnCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallIntMethod(this, global::android.database.__CrossProcessCursor._getColumnCount2203); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getColumnCount2203); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2204; 
		 byte[] android.database.Cursor.getBlob(int arg0) 
		{ 
			if (!IsClrObject) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__CrossProcessCursor._getBlob2204, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getBlob2204, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2205; 
		 void android.database.Cursor.copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._copyStringToBuffer2205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._copyStringToBuffer2205, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNull2206; 
		 bool android.database.Cursor.isNull(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._isNull2206, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._isNull2206, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deactivate2207; 
		 void android.database.Cursor.deactivate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._deactivate2207); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._deactivate2207); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requery2208; 
		 bool android.database.Cursor.requery() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._requery2208); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._requery2208); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver2209; 
		 void android.database.Cursor.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._registerDataSetObserver2209, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._registerDataSetObserver2209, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver2210; 
		 void android.database.Cursor.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._unregisterDataSetObserver2210, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._unregisterDataSetObserver2210, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNotificationUri2211; 
		 void android.database.Cursor.setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				@__env.CallVoidMethod(this, global::android.database.__CrossProcessCursor._setNotificationUri2211, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._setNotificationUri2211, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWantsAllOnMoveCalls2212; 
		 bool android.database.Cursor.getWantsAllOnMoveCalls() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return @__env.CallBooleanMethod(this, global::android.database.__CrossProcessCursor._getWantsAllOnMoveCalls2212); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._getWantsAllOnMoveCalls2212); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _respond2213; 
		 global::android.os.Bundle android.database.Cursor.respond(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (!IsClrObject) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__CrossProcessCursor._respond2213, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__CrossProcessCursor.staticClass, global::android.database.__CrossProcessCursor._respond2213, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.__CrossProcessCursor.staticClass = @__class; 
			global::android.database.__CrossProcessCursor._getWindow2173 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.CrossProcessCursor.getWindow", "()Landroid/database/CursorWindow;"); 
			global::android.database.__CrossProcessCursor._onMove2174 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.CrossProcessCursor.onMove", "(II)Z"); 
			global::android.database.__CrossProcessCursor._fillWindow2175 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.CrossProcessCursor.fillWindow", "(ILandroid/database/CursorWindow;)V"); 
			global::android.database.__CrossProcessCursor._getShort2176 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getShort", "(I)S"); 
			global::android.database.__CrossProcessCursor._getInt2177 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getInt", "(I)I"); 
			global::android.database.__CrossProcessCursor._getLong2178 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getLong", "(I)J"); 
			global::android.database.__CrossProcessCursor._getFloat2179 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getFloat", "(I)F"); 
			global::android.database.__CrossProcessCursor._getDouble2180 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getDouble", "(I)D"); 
			global::android.database.__CrossProcessCursor._close2181 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.close", "()V"); 
			global::android.database.__CrossProcessCursor._getString2182 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getString", "(I)Ljava/lang/String;"); 
			global::android.database.__CrossProcessCursor._isFirst2183 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.isFirst", "()Z"); 
			global::android.database.__CrossProcessCursor._isClosed2184 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.isClosed", "()Z"); 
			global::android.database.__CrossProcessCursor._getPosition2185 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getPosition", "()I"); 
			global::android.database.__CrossProcessCursor._getExtras2186 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getExtras", "()Landroid/os/Bundle;"); 
			global::android.database.__CrossProcessCursor._registerContentObserver2187 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.registerContentObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.database.__CrossProcessCursor._unregisterContentObserver2188 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.unregisterContentObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.database.__CrossProcessCursor._getCount2189 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getCount", "()I"); 
			global::android.database.__CrossProcessCursor._move2190 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.move", "(I)Z"); 
			global::android.database.__CrossProcessCursor._moveToPosition2191 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.moveToPosition", "(I)Z"); 
			global::android.database.__CrossProcessCursor._moveToFirst2192 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.moveToFirst", "()Z"); 
			global::android.database.__CrossProcessCursor._moveToLast2193 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.moveToLast", "()Z"); 
			global::android.database.__CrossProcessCursor._moveToNext2194 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.moveToNext", "()Z"); 
			global::android.database.__CrossProcessCursor._moveToPrevious2195 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.moveToPrevious", "()Z"); 
			global::android.database.__CrossProcessCursor._isLast2196 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.isLast", "()Z"); 
			global::android.database.__CrossProcessCursor._isBeforeFirst2197 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.isBeforeFirst", "()Z"); 
			global::android.database.__CrossProcessCursor._isAfterLast2198 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.isAfterLast", "()Z"); 
			global::android.database.__CrossProcessCursor._getColumnIndex2199 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getColumnIndex", "(Ljava/lang/String;)I"); 
			global::android.database.__CrossProcessCursor._getColumnIndexOrThrow2200 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getColumnIndexOrThrow", "(Ljava/lang/String;)I"); 
			global::android.database.__CrossProcessCursor._getColumnName2201 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getColumnName", "(I)Ljava/lang/String;"); 
			global::android.database.__CrossProcessCursor._getColumnNames2202 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getColumnNames", "()[Ljava/lang/String;"); 
			global::android.database.__CrossProcessCursor._getColumnCount2203 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getColumnCount", "()I"); 
			global::android.database.__CrossProcessCursor._getBlob2204 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getBlob", "(I)[B"); 
			global::android.database.__CrossProcessCursor._copyStringToBuffer2205 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V"); 
			global::android.database.__CrossProcessCursor._isNull2206 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.isNull", "(I)Z"); 
			global::android.database.__CrossProcessCursor._deactivate2207 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.deactivate", "()V"); 
			global::android.database.__CrossProcessCursor._requery2208 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.requery", "()Z"); 
			global::android.database.__CrossProcessCursor._registerDataSetObserver2209 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.database.__CrossProcessCursor._unregisterDataSetObserver2210 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.database.__CrossProcessCursor._setNotificationUri2211 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V"); 
			global::android.database.__CrossProcessCursor._getWantsAllOnMoveCalls2212 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.getWantsAllOnMoveCalls", "()Z"); 
			global::android.database.__CrossProcessCursor._respond2213 = @__env.GetMethodID(global::android.database.__CrossProcessCursor.staticClass, "android.database.Cursor.respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;"); 
		} 
	} 
} 
