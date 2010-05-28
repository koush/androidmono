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
		internal static global::net.sf.jni4net.jni.MethodId _getShort2214; 
		 short android.database.Cursor.getShort(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallShortMethod(this, global::android.database.__Cursor._getShort2214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualShortMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getShort2214, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInt2215; 
		 int android.database.Cursor.getInt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallIntMethod(this, global::android.database.__Cursor._getInt2215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getInt2215, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLong2216; 
		 long android.database.Cursor.getLong(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallLongMethod(this, global::android.database.__Cursor._getLong2216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getLong2216, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2217; 
		 float android.database.Cursor.getFloat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallFloatMethod(this, global::android.database.__Cursor._getFloat2217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getFloat2217, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2218; 
		 double android.database.Cursor.getDouble(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallDoubleMethod(this, global::android.database.__Cursor._getDouble2218, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getDouble2218, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close2219; 
		 void android.database.Cursor.close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				@__env.CallVoidMethod(this, global::android.database.__Cursor._close2219); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._close2219); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString2220; 
		 global::java.lang.String android.database.Cursor.getString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__Cursor._getString2220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getString2220, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFirst2221; 
		 bool android.database.Cursor.isFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._isFirst2221); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._isFirst2221); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClosed2222; 
		 bool android.database.Cursor.isClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._isClosed2222); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._isClosed2222); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPosition2223; 
		 int android.database.Cursor.getPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallIntMethod(this, global::android.database.__Cursor._getPosition2223); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getPosition2223); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtras2224; 
		 global::android.os.Bundle android.database.Cursor.getExtras() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__Cursor._getExtras2224)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getExtras2224)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerContentObserver2225; 
		 void android.database.Cursor.registerContentObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				@__env.CallVoidMethod(this, global::android.database.__Cursor._registerContentObserver2225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._registerContentObserver2225, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterContentObserver2226; 
		 void android.database.Cursor.unregisterContentObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				@__env.CallVoidMethod(this, global::android.database.__Cursor._unregisterContentObserver2226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._unregisterContentObserver2226, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount2227; 
		 int android.database.Cursor.getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallIntMethod(this, global::android.database.__Cursor._getCount2227); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getCount2227); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _move2228; 
		 bool android.database.Cursor.move(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._move2228, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._move2228, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToPosition2229; 
		 bool android.database.Cursor.moveToPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._moveToPosition2229, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._moveToPosition2229, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToFirst2230; 
		 bool android.database.Cursor.moveToFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._moveToFirst2230); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._moveToFirst2230); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToLast2231; 
		 bool android.database.Cursor.moveToLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._moveToLast2231); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._moveToLast2231); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToNext2232; 
		 bool android.database.Cursor.moveToNext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._moveToNext2232); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._moveToNext2232); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToPrevious2233; 
		 bool android.database.Cursor.moveToPrevious() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._moveToPrevious2233); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._moveToPrevious2233); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLast2234; 
		 bool android.database.Cursor.isLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._isLast2234); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._isLast2234); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBeforeFirst2235; 
		 bool android.database.Cursor.isBeforeFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._isBeforeFirst2235); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._isBeforeFirst2235); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAfterLast2236; 
		 bool android.database.Cursor.isAfterLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._isAfterLast2236); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._isAfterLast2236); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndex2237; 
		 int android.database.Cursor.getColumnIndex(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallIntMethod(this, global::android.database.__Cursor._getColumnIndex2237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getColumnIndex2237, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndexOrThrow2238; 
		 int android.database.Cursor.getColumnIndexOrThrow(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallIntMethod(this, global::android.database.__Cursor._getColumnIndexOrThrow2238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getColumnIndexOrThrow2238, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnName2239; 
		 global::java.lang.String android.database.Cursor.getColumnName(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__Cursor._getColumnName2239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getColumnName2239, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNames2240; 
		 global::java.lang.String[] android.database.Cursor.getColumnNames() 
		{ 
			if (GetType() == typeof(android.database.__Cursor)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__Cursor._getColumnNames2240)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getColumnNames2240)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnCount2241; 
		 int android.database.Cursor.getColumnCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallIntMethod(this, global::android.database.__Cursor._getColumnCount2241); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getColumnCount2241); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2242; 
		 byte[] android.database.Cursor.getBlob(int arg0) 
		{ 
			if (GetType() == typeof(android.database.__Cursor)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__Cursor._getBlob2242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getBlob2242, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2243; 
		 void android.database.Cursor.copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				@__env.CallVoidMethod(this, global::android.database.__Cursor._copyStringToBuffer2243, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._copyStringToBuffer2243, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNull2244; 
		 bool android.database.Cursor.isNull(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._isNull2244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._isNull2244, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deactivate2245; 
		 void android.database.Cursor.deactivate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				@__env.CallVoidMethod(this, global::android.database.__Cursor._deactivate2245); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._deactivate2245); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requery2246; 
		 bool android.database.Cursor.requery() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._requery2246); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._requery2246); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver2247; 
		 void android.database.Cursor.registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				@__env.CallVoidMethod(this, global::android.database.__Cursor._registerDataSetObserver2247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._registerDataSetObserver2247, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver2248; 
		 void android.database.Cursor.unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				@__env.CallVoidMethod(this, global::android.database.__Cursor._unregisterDataSetObserver2248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._unregisterDataSetObserver2248, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNotificationUri2249; 
		 void android.database.Cursor.setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				@__env.CallVoidMethod(this, global::android.database.__Cursor._setNotificationUri2249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._setNotificationUri2249, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWantsAllOnMoveCalls2250; 
		 bool android.database.Cursor.getWantsAllOnMoveCalls() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return @__env.CallBooleanMethod(this, global::android.database.__Cursor._getWantsAllOnMoveCalls2250); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._getWantsAllOnMoveCalls2250); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _respond2251; 
		 global::android.os.Bundle android.database.Cursor.respond(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.__Cursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.__Cursor._respond2251, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.__Cursor.staticClass, global::android.database.__Cursor._respond2251, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.__Cursor.staticClass = @__class; 
			global::android.database.__Cursor._getShort2214 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getShort", "(I)S"); 
			global::android.database.__Cursor._getInt2215 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getInt", "(I)I"); 
			global::android.database.__Cursor._getLong2216 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getLong", "(I)J"); 
			global::android.database.__Cursor._getFloat2217 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getFloat", "(I)F"); 
			global::android.database.__Cursor._getDouble2218 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getDouble", "(I)D"); 
			global::android.database.__Cursor._close2219 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.close", "()V"); 
			global::android.database.__Cursor._getString2220 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getString", "(I)Ljava/lang/String;"); 
			global::android.database.__Cursor._isFirst2221 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.isFirst", "()Z"); 
			global::android.database.__Cursor._isClosed2222 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.isClosed", "()Z"); 
			global::android.database.__Cursor._getPosition2223 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getPosition", "()I"); 
			global::android.database.__Cursor._getExtras2224 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getExtras", "()Landroid/os/Bundle;"); 
			global::android.database.__Cursor._registerContentObserver2225 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.registerContentObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.database.__Cursor._unregisterContentObserver2226 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.unregisterContentObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.database.__Cursor._getCount2227 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getCount", "()I"); 
			global::android.database.__Cursor._move2228 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.move", "(I)Z"); 
			global::android.database.__Cursor._moveToPosition2229 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.moveToPosition", "(I)Z"); 
			global::android.database.__Cursor._moveToFirst2230 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.moveToFirst", "()Z"); 
			global::android.database.__Cursor._moveToLast2231 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.moveToLast", "()Z"); 
			global::android.database.__Cursor._moveToNext2232 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.moveToNext", "()Z"); 
			global::android.database.__Cursor._moveToPrevious2233 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.moveToPrevious", "()Z"); 
			global::android.database.__Cursor._isLast2234 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.isLast", "()Z"); 
			global::android.database.__Cursor._isBeforeFirst2235 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.isBeforeFirst", "()Z"); 
			global::android.database.__Cursor._isAfterLast2236 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.isAfterLast", "()Z"); 
			global::android.database.__Cursor._getColumnIndex2237 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getColumnIndex", "(Ljava/lang/String;)I"); 
			global::android.database.__Cursor._getColumnIndexOrThrow2238 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getColumnIndexOrThrow", "(Ljava/lang/String;)I"); 
			global::android.database.__Cursor._getColumnName2239 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getColumnName", "(I)Ljava/lang/String;"); 
			global::android.database.__Cursor._getColumnNames2240 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getColumnNames", "()[Ljava/lang/String;"); 
			global::android.database.__Cursor._getColumnCount2241 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getColumnCount", "()I"); 
			global::android.database.__Cursor._getBlob2242 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getBlob", "(I)[B"); 
			global::android.database.__Cursor._copyStringToBuffer2243 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V"); 
			global::android.database.__Cursor._isNull2244 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.isNull", "(I)Z"); 
			global::android.database.__Cursor._deactivate2245 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.deactivate", "()V"); 
			global::android.database.__Cursor._requery2246 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.requery", "()Z"); 
			global::android.database.__Cursor._registerDataSetObserver2247 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.database.__Cursor._unregisterDataSetObserver2248 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.database.__Cursor._setNotificationUri2249 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V"); 
			global::android.database.__Cursor._getWantsAllOnMoveCalls2250 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.getWantsAllOnMoveCalls", "()Z"); 
			global::android.database.__Cursor._respond2251 = @__env.GetMethodID(global::android.database.__Cursor.staticClass, "android.database.Cursor.respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;"); 
		} 
	} 
} 
