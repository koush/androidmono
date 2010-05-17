namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class CursorWrapper : java.lang.Object, Cursor
	{ 
		internal static global::java.lang.Class staticClass; 
		static CursorWrapper() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.CursorWrapper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
		{ 
			public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
			{ 
				return new global::android.database.CursorWrapper(@__env); 
			} 
		} 
		protected CursorWrapper(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShort2112; 
		public virtual short getShort(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallShortMethod(this, _getShort2112, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualShortMethod(this, android.database.CursorWrapper.staticClass, _getShort2112, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInt2113; 
		public virtual int getInt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallIntMethod(this, _getInt2113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.CursorWrapper.staticClass, _getInt2113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLong2114; 
		public virtual long getLong(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallLongMethod(this, _getLong2114, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, android.database.CursorWrapper.staticClass, _getLong2114, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2115; 
		public virtual float getFloat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallFloatMethod(this, _getFloat2115, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, android.database.CursorWrapper.staticClass, _getFloat2115, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2116; 
		public virtual double getDouble(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallDoubleMethod(this, _getDouble2116, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, android.database.CursorWrapper.staticClass, _getDouble2116, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close2117; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, _close2117); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWrapper.staticClass, _close2117); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString2118; 
		public virtual java.lang.String getString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getString2118, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.CursorWrapper.staticClass, _getString2118, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFirst2119; 
		public virtual bool isFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, _isFirst2119); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWrapper.staticClass, _isFirst2119); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClosed2120; 
		public virtual bool isClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, _isClosed2120); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWrapper.staticClass, _isClosed2120); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPosition2121; 
		public virtual int getPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallIntMethod(this, _getPosition2121); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.CursorWrapper.staticClass, _getPosition2121); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtras2122; 
		public virtual android.os.Bundle getExtras() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _getExtras2122)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.CursorWrapper.staticClass, _getExtras2122)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerContentObserver2123; 
		public virtual void registerContentObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, _registerContentObserver2123, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWrapper.staticClass, _registerContentObserver2123, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterContentObserver2124; 
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, _unregisterContentObserver2124, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWrapper.staticClass, _unregisterContentObserver2124, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount2125; 
		public virtual int getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallIntMethod(this, _getCount2125); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.CursorWrapper.staticClass, _getCount2125); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _move2126; 
		public virtual bool move(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, _move2126, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWrapper.staticClass, _move2126, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToPosition2127; 
		public virtual bool moveToPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, _moveToPosition2127, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWrapper.staticClass, _moveToPosition2127, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToFirst2128; 
		public virtual bool moveToFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, _moveToFirst2128); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWrapper.staticClass, _moveToFirst2128); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToLast2129; 
		public virtual bool moveToLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, _moveToLast2129); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWrapper.staticClass, _moveToLast2129); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToNext2130; 
		public virtual bool moveToNext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, _moveToNext2130); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWrapper.staticClass, _moveToNext2130); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToPrevious2131; 
		public virtual bool moveToPrevious() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, _moveToPrevious2131); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWrapper.staticClass, _moveToPrevious2131); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLast2132; 
		public virtual bool isLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, _isLast2132); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWrapper.staticClass, _isLast2132); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBeforeFirst2133; 
		public virtual bool isBeforeFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, _isBeforeFirst2133); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWrapper.staticClass, _isBeforeFirst2133); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAfterLast2134; 
		public virtual bool isAfterLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, _isAfterLast2134); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWrapper.staticClass, _isAfterLast2134); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndex2135; 
		public virtual int getColumnIndex(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallIntMethod(this, _getColumnIndex2135, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.CursorWrapper.staticClass, _getColumnIndex2135, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndexOrThrow2136; 
		public virtual int getColumnIndexOrThrow(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallIntMethod(this, _getColumnIndexOrThrow2136, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.CursorWrapper.staticClass, _getColumnIndexOrThrow2136, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnName2137; 
		public virtual java.lang.String getColumnName(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getColumnName2137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.CursorWrapper.staticClass, _getColumnName2137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNames2138; 
		public virtual java.lang.String[] getColumnNames() 
		{ 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getColumnNames2138)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.CursorWrapper.staticClass, _getColumnNames2138)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnCount2139; 
		public virtual int getColumnCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallIntMethod(this, _getColumnCount2139); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.CursorWrapper.staticClass, _getColumnCount2139); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2140; 
		public virtual byte[] getBlob(int arg0) 
		{ 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getBlob2140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.CursorWrapper.staticClass, _getBlob2140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2141; 
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, _copyStringToBuffer2141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWrapper.staticClass, _copyStringToBuffer2141, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNull2142; 
		public virtual bool isNull(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, _isNull2142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWrapper.staticClass, _isNull2142, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deactivate2143; 
		public virtual void deactivate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, _deactivate2143); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWrapper.staticClass, _deactivate2143); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requery2144; 
		public virtual bool requery() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, _requery2144); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWrapper.staticClass, _requery2144); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver2145; 
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, _registerDataSetObserver2145, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWrapper.staticClass, _registerDataSetObserver2145, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver2146; 
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, _unregisterDataSetObserver2146, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWrapper.staticClass, _unregisterDataSetObserver2146, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNotificationUri2147; 
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, _setNotificationUri2147, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.CursorWrapper.staticClass, _setNotificationUri2147, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWantsAllOnMoveCalls2148; 
		public virtual bool getWantsAllOnMoveCalls() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, _getWantsAllOnMoveCalls2148); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.CursorWrapper.staticClass, _getWantsAllOnMoveCalls2148); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _respond2149; 
		public virtual android.os.Bundle respond(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _respond2149, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.CursorWrapper.staticClass, _respond2149, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CursorWrapper2150; 
		public CursorWrapper(android.database.Cursor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.CursorWrapper.staticClass, _CursorWrapper2150, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.CursorWrapper.staticClass = @__class; 
			global::android.database.CursorWrapper._getShort2112 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getShort", "(I)S"); 
			global::android.database.CursorWrapper._getInt2113 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getInt", "(I)I"); 
			global::android.database.CursorWrapper._getLong2114 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getLong", "(I)J"); 
			global::android.database.CursorWrapper._getFloat2115 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getFloat", "(I)F"); 
			global::android.database.CursorWrapper._getDouble2116 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getDouble", "(I)D"); 
			global::android.database.CursorWrapper._close2117 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "close", "()V"); 
			global::android.database.CursorWrapper._getString2118 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getString", "(I)Ljava/lang/String;"); 
			global::android.database.CursorWrapper._isFirst2119 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isFirst", "()Z"); 
			global::android.database.CursorWrapper._isClosed2120 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isClosed", "()Z"); 
			global::android.database.CursorWrapper._getPosition2121 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getPosition", "()I"); 
			global::android.database.CursorWrapper._getExtras2122 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getExtras", "()Landroid/os/Bundle;"); 
			global::android.database.CursorWrapper._registerContentObserver2123 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.database.CursorWrapper._unregisterContentObserver2124 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.database.CursorWrapper._getCount2125 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getCount", "()I"); 
			global::android.database.CursorWrapper._move2126 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "move", "(I)Z"); 
			global::android.database.CursorWrapper._moveToPosition2127 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "moveToPosition", "(I)Z"); 
			global::android.database.CursorWrapper._moveToFirst2128 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "moveToFirst", "()Z"); 
			global::android.database.CursorWrapper._moveToLast2129 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "moveToLast", "()Z"); 
			global::android.database.CursorWrapper._moveToNext2130 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "moveToNext", "()Z"); 
			global::android.database.CursorWrapper._moveToPrevious2131 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "moveToPrevious", "()Z"); 
			global::android.database.CursorWrapper._isLast2132 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isLast", "()Z"); 
			global::android.database.CursorWrapper._isBeforeFirst2133 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isBeforeFirst", "()Z"); 
			global::android.database.CursorWrapper._isAfterLast2134 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isAfterLast", "()Z"); 
			global::android.database.CursorWrapper._getColumnIndex2135 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getColumnIndex", "(Ljava/lang/String;)I"); 
			global::android.database.CursorWrapper._getColumnIndexOrThrow2136 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I"); 
			global::android.database.CursorWrapper._getColumnName2137 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getColumnName", "(I)Ljava/lang/String;"); 
			global::android.database.CursorWrapper._getColumnNames2138 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getColumnNames", "()[Ljava/lang/String;"); 
			global::android.database.CursorWrapper._getColumnCount2139 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getColumnCount", "()I"); 
			global::android.database.CursorWrapper._getBlob2140 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getBlob", "(I)[B"); 
			global::android.database.CursorWrapper._copyStringToBuffer2141 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V"); 
			global::android.database.CursorWrapper._isNull2142 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isNull", "(I)Z"); 
			global::android.database.CursorWrapper._deactivate2143 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "deactivate", "()V"); 
			global::android.database.CursorWrapper._requery2144 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "requery", "()Z"); 
			global::android.database.CursorWrapper._registerDataSetObserver2145 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.database.CursorWrapper._unregisterDataSetObserver2146 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.database.CursorWrapper._setNotificationUri2147 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V"); 
			global::android.database.CursorWrapper._getWantsAllOnMoveCalls2148 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getWantsAllOnMoveCalls", "()Z"); 
			global::android.database.CursorWrapper._respond2149 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;"); 
			global::android.database.CursorWrapper._CursorWrapper2150 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "<init>", "(Landroid/database/Cursor;)V"); 
		} 
	} 
} 
