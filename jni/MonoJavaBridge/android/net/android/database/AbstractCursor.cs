namespace android.database 
{ 
	[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
	public abstract class AbstractCursor : java.lang.Object, CrossProcessCursor
	{ 
		internal static global::java.lang.Class staticClass; 
		static AbstractCursor() 
		{ 
			global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.AbstractCursor), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
		} 
		protected AbstractCursor(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
		{ 
		} 
		[global::net.sf.jni4net.attributes.JavaClassAttribute()] 
		protected class SelfContentObserver : android.database.ContentObserver
		{ 
			internal new static global::java.lang.Class staticClass; 
			static SelfContentObserver() 
			{ 
				global::net.sf.jni4net.utils.Registry.RegisterType(typeof(android.database.AbstractCursor.SelfContentObserver), true, global::net.sf.jni4net.jni.JNIEnv.ThreadEnv); 
			} 
			private sealed class ContructionHelper : global::net.sf.jni4net.utils.IConstructionHelper 
			{ 
				public global::net.sf.jni4net.jni.IJvmProxy CreateProxy(global::net.sf.jni4net.jni.JNIEnv @__env) 
				{ 
					return new global::android.database.AbstractCursor.SelfContentObserver(@__env); 
				} 
			} 
			protected SelfContentObserver(global::net.sf.jni4net.jni.JNIEnv @__env) : base(@__env) 
			{ 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _deliverSelfNotifications2094; 
			public override bool deliverSelfNotifications() 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.AbstractCursor.SelfContentObserver)) 
					return @__env.CallBooleanMethod(this, _deliverSelfNotifications2094); 
				else 
					return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.SelfContentObserver.staticClass, _deliverSelfNotifications2094); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _onChange2095; 
			public override void onChange(bool arg0) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				if (GetType() == typeof(android.database.AbstractCursor.SelfContentObserver)) 
					@__env.CallVoidMethod(this, _onChange2095, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
				else 
					@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.SelfContentObserver.staticClass, _onChange2095, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			} 
			internal static global::net.sf.jni4net.jni.MethodId _SelfContentObserver2096; 
			public SelfContentObserver(android.database.AbstractCursor arg0)  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
			{ 
				global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
				@__env.NewObject(android.database.AbstractCursor.SelfContentObserver.staticClass, _SelfContentObserver2096, this, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			} 
			private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
			{ 
				global::android.database.AbstractCursor.SelfContentObserver.staticClass = @__class; 
				global::android.database.AbstractCursor.SelfContentObserver._deliverSelfNotifications2094 = @__env.GetMethodID(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "deliverSelfNotifications", "()Z"); 
				global::android.database.AbstractCursor.SelfContentObserver._onChange2095 = @__env.GetMethodID(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "onChange", "(Z)V"); 
				global::android.database.AbstractCursor.SelfContentObserver._SelfContentObserver2096 = @__env.GetMethodID(global::android.database.AbstractCursor.SelfContentObserver.staticClass, "<init>", "(Landroid/database/AbstractCursor;)V"); 
			} 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getShort2097; 
		public abstract short getShort(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getInt2098; 
		public abstract int getInt(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getLong2099; 
		public abstract long getLong(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getFloat2100; 
		public abstract float getFloat(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _getDouble2101; 
		public abstract double getDouble(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _close2102; 
		public virtual void close() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _close2102); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _close2102); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getString2103; 
		public abstract java.lang.String getString(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _isFirst2104; 
		public virtual bool isFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _isFirst2104); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _isFirst2104); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isClosed2105; 
		public virtual bool isClosed() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _isClosed2105); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _isClosed2105); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getPosition2106; 
		public virtual int getPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallIntMethod(this, _getPosition2106); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.AbstractCursor.staticClass, _getPosition2106); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getExtras2107; 
		public virtual android.os.Bundle getExtras() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _getExtras2107)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.AbstractCursor.staticClass, _getExtras2107)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerContentObserver2108; 
		public virtual void registerContentObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _registerContentObserver2108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _registerContentObserver2108, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterContentObserver2109; 
		public virtual void unregisterContentObserver(android.database.ContentObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _unregisterContentObserver2109, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _unregisterContentObserver2109, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWindow2110; 
		public virtual android.database.CursorWindow getWindow() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallObjectMethodPtr(this, _getWindow2110)); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.database.CursorWindow>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.AbstractCursor.staticClass, _getWindow2110)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getCount2111; 
		public abstract int getCount(); 
		internal static global::net.sf.jni4net.jni.MethodId _move2112; 
		public virtual bool move(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _move2112, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _move2112, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToPosition2113; 
		public virtual bool moveToPosition(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _moveToPosition2113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _moveToPosition2113, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToFirst2114; 
		public virtual bool moveToFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _moveToFirst2114); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _moveToFirst2114); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToLast2115; 
		public virtual bool moveToLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _moveToLast2115); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _moveToLast2115); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToNext2116; 
		public virtual bool moveToNext() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _moveToNext2116); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _moveToNext2116); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _moveToPrevious2117; 
		public virtual bool moveToPrevious() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _moveToPrevious2117); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _moveToPrevious2117); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isLast2118; 
		public virtual bool isLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _isLast2118); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _isLast2118); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isBeforeFirst2119; 
		public virtual bool isBeforeFirst() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _isBeforeFirst2119); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _isBeforeFirst2119); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isAfterLast2120; 
		public virtual bool isAfterLast() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _isAfterLast2120); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _isAfterLast2120); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndex2121; 
		public virtual int getColumnIndex(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallIntMethod(this, _getColumnIndex2121, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.AbstractCursor.staticClass, _getColumnIndex2121, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnIndexOrThrow2122; 
		public virtual int getColumnIndexOrThrow(java.lang.String arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallIntMethod(this, _getColumnIndexOrThrow2122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.AbstractCursor.staticClass, _getColumnIndexOrThrow2122, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnName2123; 
		public virtual java.lang.String getColumnName(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallObjectMethodPtr(this, _getColumnName2123, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<java.lang.String>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.AbstractCursor.staticClass, _getColumnName2123, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnNames2124; 
		public abstract java.lang.String[] getColumnNames(); 
		internal static global::net.sf.jni4net.jni.MethodId _getColumnCount2125; 
		public virtual int getColumnCount() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallIntMethod(this, _getColumnCount2125); 
			else 
				return @__env.CallNonVirtualIntMethod(this, android.database.AbstractCursor.staticClass, _getColumnCount2125); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getBlob2126; 
		public virtual byte[] getBlob(int arg0) 
		{ 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return null;//(@__env, @__env.CallObjectMethodPtr(this, _getBlob2126, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return null;//(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.AbstractCursor.staticClass, _getBlob2126, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _copyStringToBuffer2127; 
		public virtual void copyStringToBuffer(int arg0, android.database.CharArrayBuffer arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _copyStringToBuffer2127, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _copyStringToBuffer2127, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isNull2128; 
		public abstract bool isNull(int arg0); 
		internal static global::net.sf.jni4net.jni.MethodId _deactivate2129; 
		public virtual void deactivate() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _deactivate2129); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _deactivate2129); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _requery2130; 
		public virtual bool requery() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _requery2130); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _requery2130); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _registerDataSetObserver2131; 
		public virtual void registerDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _registerDataSetObserver2131, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _registerDataSetObserver2131, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _unregisterDataSetObserver2132; 
		public virtual void unregisterDataSetObserver(android.database.DataSetObserver arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _unregisterDataSetObserver2132, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _unregisterDataSetObserver2132, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _setNotificationUri2133; 
		public virtual void setNotificationUri(android.content.ContentResolver arg0, android.net.Uri arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _setNotificationUri2133, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _setNotificationUri2133, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getWantsAllOnMoveCalls2134; 
		public virtual bool getWantsAllOnMoveCalls() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _getWantsAllOnMoveCalls2134); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _getWantsAllOnMoveCalls2134); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _respond2135; 
		public virtual android.os.Bundle respond(android.os.Bundle arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallObjectMethodPtr(this, _respond2135, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.StrongJ2Cp<android.os.Bundle>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.AbstractCursor.staticClass, _respond2135, global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onChange2136; 
		protected virtual void onChange(bool arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _onChange2136, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _onChange2136, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _onMove2137; 
		public virtual bool onMove(int arg0, int arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _onMove2137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _onMove2137, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _fillWindow2138; 
		public virtual void fillWindow(int arg0, android.database.CursorWindow arg1) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _fillWindow2138, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _fillWindow2138, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0), global::net.sf.jni4net.utils.Convertor.ParStrongCp2J(arg1)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _isFieldUpdated2139; 
		protected virtual bool isFieldUpdated(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return @__env.CallBooleanMethod(this, _isFieldUpdated2139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
			else 
				return @__env.CallNonVirtualBooleanMethod(this, android.database.AbstractCursor.staticClass, _isFieldUpdated2139, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0)); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _getUpdatedField2140; 
		protected virtual java.lang.Object getUpdatedField(int arg0) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallObjectMethodPtr(this, _getUpdatedField2140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
			else 
				return global::net.sf.jni4net.utils.Convertor.FullJ2C<java.lang.Object>(@__env, @__env.CallNonVirtualObjectMethodPtr(this, android.database.AbstractCursor.staticClass, _getUpdatedField2140, global::net.sf.jni4net.utils.Convertor.ParPrimC2J(arg0))); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _checkPosition2141; 
		protected virtual void checkPosition() 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			if (GetType() == typeof(android.database.AbstractCursor)) 
				@__env.CallVoidMethod(this, _checkPosition2141); 
			else 
				@__env.CallNonVirtualVoidMethod(this, android.database.AbstractCursor.staticClass, _checkPosition2141); 
		} 
		internal static global::net.sf.jni4net.jni.MethodId _AbstractCursor2142; 
		public AbstractCursor()  : base(global::net.sf.jni4net.jni.JNIEnv.ThreadEnv) 
		{ 
			global::net.sf.jni4net.jni.JNIEnv @__env = global::net.sf.jni4net.jni.JNIEnv.ThreadEnv; 
			@__env.NewObject(android.database.AbstractCursor.staticClass, _AbstractCursor2142, this); 
		} 
		private static void InitJNI(global::net.sf.jni4net.jni.JNIEnv @__env, java.lang.Class @__class) 
		{ 
			global::android.database.AbstractCursor.staticClass = @__class; 
			global::android.database.AbstractCursor._getShort2097 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getShort", "(I)S"); 
			global::android.database.AbstractCursor._getInt2098 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getInt", "(I)I"); 
			global::android.database.AbstractCursor._getLong2099 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getLong", "(I)J"); 
			global::android.database.AbstractCursor._getFloat2100 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getFloat", "(I)F"); 
			global::android.database.AbstractCursor._getDouble2101 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getDouble", "(I)D"); 
			global::android.database.AbstractCursor._close2102 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "close", "()V"); 
			global::android.database.AbstractCursor._getString2103 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getString", "(I)Ljava/lang/String;"); 
			global::android.database.AbstractCursor._isFirst2104 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isFirst", "()Z"); 
			global::android.database.AbstractCursor._isClosed2105 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isClosed", "()Z"); 
			global::android.database.AbstractCursor._getPosition2106 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getPosition", "()I"); 
			global::android.database.AbstractCursor._getExtras2107 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getExtras", "()Landroid/os/Bundle;"); 
			global::android.database.AbstractCursor._registerContentObserver2108 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "registerContentObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.database.AbstractCursor._unregisterContentObserver2109 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "unregisterContentObserver", "(Landroid/database/ContentObserver;)V"); 
			global::android.database.AbstractCursor._getWindow2110 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getWindow", "()Landroid/database/CursorWindow;"); 
			global::android.database.AbstractCursor._getCount2111 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getCount", "()I"); 
			global::android.database.AbstractCursor._move2112 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "move", "(I)Z"); 
			global::android.database.AbstractCursor._moveToPosition2113 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "moveToPosition", "(I)Z"); 
			global::android.database.AbstractCursor._moveToFirst2114 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "moveToFirst", "()Z"); 
			global::android.database.AbstractCursor._moveToLast2115 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "moveToLast", "()Z"); 
			global::android.database.AbstractCursor._moveToNext2116 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "moveToNext", "()Z"); 
			global::android.database.AbstractCursor._moveToPrevious2117 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "moveToPrevious", "()Z"); 
			global::android.database.AbstractCursor._isLast2118 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isLast", "()Z"); 
			global::android.database.AbstractCursor._isBeforeFirst2119 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isBeforeFirst", "()Z"); 
			global::android.database.AbstractCursor._isAfterLast2120 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isAfterLast", "()Z"); 
			global::android.database.AbstractCursor._getColumnIndex2121 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getColumnIndex", "(Ljava/lang/String;)I"); 
			global::android.database.AbstractCursor._getColumnIndexOrThrow2122 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getColumnIndexOrThrow", "(Ljava/lang/String;)I"); 
			global::android.database.AbstractCursor._getColumnName2123 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getColumnName", "(I)Ljava/lang/String;"); 
			global::android.database.AbstractCursor._getColumnNames2124 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getColumnNames", "()[Ljava/lang/String;"); 
			global::android.database.AbstractCursor._getColumnCount2125 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getColumnCount", "()I"); 
			global::android.database.AbstractCursor._getBlob2126 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getBlob", "(I)[B"); 
			global::android.database.AbstractCursor._copyStringToBuffer2127 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "copyStringToBuffer", "(ILandroid/database/CharArrayBuffer;)V"); 
			global::android.database.AbstractCursor._isNull2128 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isNull", "(I)Z"); 
			global::android.database.AbstractCursor._deactivate2129 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "deactivate", "()V"); 
			global::android.database.AbstractCursor._requery2130 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "requery", "()Z"); 
			global::android.database.AbstractCursor._registerDataSetObserver2131 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "registerDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.database.AbstractCursor._unregisterDataSetObserver2132 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "unregisterDataSetObserver", "(Landroid/database/DataSetObserver;)V"); 
			global::android.database.AbstractCursor._setNotificationUri2133 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "setNotificationUri", "(Landroid/content/ContentResolver;Landroid/net/Uri;)V"); 
			global::android.database.AbstractCursor._getWantsAllOnMoveCalls2134 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getWantsAllOnMoveCalls", "()Z"); 
			global::android.database.AbstractCursor._respond2135 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "respond", "(Landroid/os/Bundle;)Landroid/os/Bundle;"); 
			global::android.database.AbstractCursor._onChange2136 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "onChange", "(Z)V"); 
			global::android.database.AbstractCursor._onMove2137 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "onMove", "(II)Z"); 
			global::android.database.AbstractCursor._fillWindow2138 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "fillWindow", "(ILandroid/database/CursorWindow;)V"); 
			global::android.database.AbstractCursor._isFieldUpdated2139 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "isFieldUpdated", "(I)Z"); 
			global::android.database.AbstractCursor._getUpdatedField2140 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "getUpdatedField", "(I)Ljava/lang/Object;"); 
			global::android.database.AbstractCursor._checkPosition2141 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "checkPosition", "()V"); 
			global::android.database.AbstractCursor._AbstractCursor2142 = @__env.GetMethodID(global::android.database.AbstractCursor.staticClass, "<init>", "()V"); 
		} 
	} 
} 
