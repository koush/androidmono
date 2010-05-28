namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public class CursorWrapper : java.lang.Object, Cursor
	{ 
		internal static global::java.lang.Class staticClass; 
		static CursorWrapper() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(global::android.database.CursorWrapper), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
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
		internal static global::net.sf.jni4net.jni.MethodId _getShort2296; 
		public virtual short getShort(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallShortMethod(this, global::android.database.CursorWrapper._getShort2296, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualShortMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getShort2296, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getInt2297; 
		public virtual int getInt(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallIntMethod(this, global::android.database.CursorWrapper._getInt2297, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getInt2297, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getLong2298; 
		public virtual long getLong(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallLongMethod(this, global::android.database.CursorWrapper._getLong2298, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualLongMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getLong2298, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2299; 
		public virtual float getFloat(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallFloatMethod(this, global::android.database.CursorWrapper._getFloat2299, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualFloatMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getFloat2299, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2300; 
		public virtual double getDouble(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallDoubleMethod(this, global::android.database.CursorWrapper._getDouble2300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualDoubleMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getDouble2300, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _close2301; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._close2301); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._close2301); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString2302; 
		public virtual global::java.lang.String getString(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorWrapper._getString2302, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getString2302, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFirst2303; 
		public virtual bool isFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._isFirst2303); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isFirst2303); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClosed2304; 
		public virtual bool isClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._isClosed2304); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isClosed2304); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPosition2305; 
		public virtual int getPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallIntMethod(this, global::android.database.CursorWrapper._getPosition2305); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getPosition2305); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtras2306; 
		public virtual global::android.os.Bundle getExtras() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorWrapper._getExtras2306)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getExtras2306)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerContentObserver2307; 
		public virtual void registerContentObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._registerContentObserver2307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._registerContentObserver2307, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterContentObserver2308; 
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._unregisterContentObserver2308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._unregisterContentObserver2308, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount2309; 
		public virtual int getCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallIntMethod(this, global::android.database.CursorWrapper._getCount2309); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getCount2309); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _move2310; 
		public virtual bool move(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._move2310, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._move2310, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToPosition2311; 
		public virtual bool moveToPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._moveToPosition2311, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToPosition2311, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToFirst2312; 
		public virtual bool moveToFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._moveToFirst2312); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToFirst2312); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToLast2313; 
		public virtual bool moveToLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._moveToLast2313); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToLast2313); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToNext2314; 
		public virtual bool moveToNext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._moveToNext2314); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToNext2314); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToPrevious2315; 
		public virtual bool moveToPrevious() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._moveToPrevious2315); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._moveToPrevious2315); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLast2316; 
		public virtual bool isLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._isLast2316); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isLast2316); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBeforeFirst2317; 
		public virtual bool isBeforeFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._isBeforeFirst2317); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isBeforeFirst2317); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAfterLast2318; 
		public virtual bool isAfterLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._isAfterLast2318); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isAfterLast2318); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndex2319; 
		public virtual int getColumnIndex(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallIntMethod(this, global::android.database.CursorWrapper._getColumnIndex2319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnIndex2319, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndexOrThrow2320; 
		public virtual int getColumnIndexOrThrow(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallIntMethod(this, global::android.database.CursorWrapper._getColumnIndexOrThrow2320, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnIndexOrThrow2320, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnName2321; 
		public virtual global::java.lang.String getColumnName(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorWrapper._getColumnName2321, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnName2321, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNames2322; 
		public virtual global::java.lang.String[] getColumnNames() 
		{ 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorWrapper._getColumnNames2322)); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnNames2322)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnCount2323; 
		public virtual int getColumnCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallIntMethod(this, global::android.database.CursorWrapper._getColumnCount2323); 
			else 
				return @__env.CallNonVirtualIntMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getColumnCount2323); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2324; 
		public virtual byte[] getBlob(int arg0) 
		{ 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorWrapper._getBlob2324, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getBlob2324, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2325; 
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._copyStringToBuffer2325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._copyStringToBuffer2325, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNull2326; 
		public virtual bool isNull(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._isNull2326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._isNull2326, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _deactivate2327; 
		public virtual void deactivate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._deactivate2327); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._deactivate2327); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requery2328; 
		public virtual bool requery() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._requery2328); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._requery2328); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver2329; 
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._registerDataSetObserver2329, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._registerDataSetObserver2329, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver2330; 
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._unregisterDataSetObserver2330, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._unregisterDataSetObserver2330, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNotificationUri2331; 
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				@__env.CallVoidMethod(this, global::android.database.CursorWrapper._setNotificationUri2331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._setNotificationUri2331, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWantsAllOnMoveCalls2332; 
		public virtual bool getWantsAllOnMoveCalls() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return @__env.CallBooleanMethod(this, global::android.database.CursorWrapper._getWantsAllOnMoveCalls2332); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._getWantsAllOnMoveCalls2332); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _respond2333; 
		public virtual global::android.os.Bundle respond(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.CursorWrapper)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, global::android.database.CursorWrapper._respond2333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, global::android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._respond2333, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _CursorWrapper2334; 
		public CursorWrapper(android.database.Cursor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.CursorWrapper.staticClass, global::android.database.CursorWrapper._CursorWrapper2334, this, global::net.sf.jni4net.utils.Convertor.ParFullC2J(@__env, arg0)); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.CursorWrapper.staticClass = @__class; 
			global::android.database.CursorWrapper._getShort2296 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getShort", "(I)S"); 
			global::android.database.CursorWrapper._getInt2297 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getInt", "(I)I"); 
			global::android.database.CursorWrapper._getLong2298 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getLong", "(I)J"); 
			global::android.database.CursorWrapper._getFloat2299 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getFloat", "(I)F"); 
			global::android.database.CursorWrapper._getDouble2300 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getDouble", "(I)D"); 
			global::android.database.CursorWrapper._close2301 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "close", "()V"); 
			global::android.database.CursorWrapper._getString2302 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getString", "(I)Ljava/lang/String;"); 
			global::android.database.CursorWrapper._isFirst2303 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isFirst", "()Z"); 
			global::android.database.CursorWrapper._isClosed2304 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isClosed", "()Z"); 
			global::android.database.CursorWrapper._getPosition2305 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getPosition", "()I"); 
			global::android.database.CursorWrapper._getExtras2306 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getExtras", "()Landroid/os/Bundle;"); 
			global::android.database.CursorWrapper._registerContentObserver2307 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.database.CursorWrapper._unregisterContentObserver2308 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.database.CursorWrapper._getCount2309 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getCount", "()I"); 
			global::android.database.CursorWrapper._move2310 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "move", "(I)Z"); 
			global::android.database.CursorWrapper._moveToPosition2311 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "moveToPosition", "(I)Z"); 
			global::android.database.CursorWrapper._moveToFirst2312 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "moveToFirst", "()Z"); 
			global::android.database.CursorWrapper._moveToLast2313 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "moveToLast", "()Z"); 
			global::android.database.CursorWrapper._moveToNext2314 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "moveToNext", "()Z"); 
			global::android.database.CursorWrapper._moveToPrevious2315 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "moveToPrevious", "()Z"); 
			global::android.database.CursorWrapper._isLast2316 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isLast", "()Z"); 
			global::android.database.CursorWrapper._isBeforeFirst2317 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isBeforeFirst", "()Z"); 
			global::android.database.CursorWrapper._isAfterLast2318 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isAfterLast", "()Z"); 
			global::android.database.CursorWrapper._getColumnIndex2319 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getColumnIndex", "(Ljava/lang/String;)I"); 
			global::android.database.CursorWrapper._getColumnIndexOrThrow2320 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I"); 
			global::android.database.CursorWrapper._getColumnName2321 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getColumnName", "(I)Ljava/lang/String;"); 
			global::android.database.CursorWrapper._getColumnNames2322 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getColumnNames", "()[Ljava/lang/String;"); 
			global::android.database.CursorWrapper._getColumnCount2323 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getColumnCount", "()I"); 
			global::android.database.CursorWrapper._getBlob2324 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getBlob", "(I)[B"); 
			global::android.database.CursorWrapper._copyStringToBuffer2325 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V"); 
			global::android.database.CursorWrapper._isNull2326 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "isNull", "(I)Z"); 
			global::android.database.CursorWrapper._deactivate2327 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "deactivate", "()V"); 
			global::android.database.CursorWrapper._requery2328 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "requery", "()Z"); 
			global::android.database.CursorWrapper._registerDataSetObserver2329 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.database.CursorWrapper._unregisterDataSetObserver2330 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.database.CursorWrapper._setNotificationUri2331 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V"); 
			global::android.database.CursorWrapper._getWantsAllOnMoveCalls2332 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "getWantsAllOnMoveCalls", "()Z"); 
			global::android.database.CursorWrapper._respond2333 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;"); 
			global::android.database.CursorWrapper._CursorWrapper2334 = @__env.GetMethodID(global::android.database.CursorWrapper.staticClass, "<init>", "(Landroid/database/Cursor;)V"); 
		} 
	} 
} 
