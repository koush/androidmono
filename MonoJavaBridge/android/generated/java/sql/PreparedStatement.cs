namespace java.sql
{
	[global::MonoJavaBridge.JavaInterface(typeof(global::java.sql.PreparedStatement_))]
	public partial interface PreparedStatement : Statement
	{
		void setBoolean(int arg0, bool arg1);
		void setByte(int arg0, byte arg1);
		void setShort(int arg0, short arg1);
		void setInt(int arg0, int arg1);
		void setLong(int arg0, long arg1);
		void setFloat(int arg0, float arg1);
		void setDouble(int arg0, double arg1);
		void setTimestamp(int arg0, java.sql.Timestamp arg1);
		void setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2);
		void setURL(int arg0, java.net.URL arg1);
		void setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2);
		void setTime(int arg0, java.sql.Time arg1);
		void setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2);
		void setDate(int arg0, java.sql.Date arg1);
		bool execute();
		void addBatch();
		void setString(int arg0, java.lang.String arg1);
		void setObject(int arg0, java.lang.Object arg1, int arg2);
		void setObject(int arg0, java.lang.Object arg1, int arg2, int arg3);
		void setObject(int arg0, java.lang.Object arg1);
		global::java.sql.ResultSetMetaData getMetaData();
		void setBytes(int arg0, byte[] arg1);
		void setBinaryStream(int arg0, java.io.InputStream arg1);
		void setBinaryStream(int arg0, java.io.InputStream arg1, int arg2);
		void setBinaryStream(int arg0, java.io.InputStream arg1, long arg2);
		void setNull(int arg0, int arg1, java.lang.String arg2);
		void setNull(int arg0, int arg1);
		void setBigDecimal(int arg0, java.math.BigDecimal arg1);
		void setAsciiStream(int arg0, java.io.InputStream arg1, int arg2);
		void setAsciiStream(int arg0, java.io.InputStream arg1);
		void setAsciiStream(int arg0, java.io.InputStream arg1, long arg2);
		void setCharacterStream(int arg0, java.io.Reader arg1, int arg2);
		void setCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void setCharacterStream(int arg0, java.io.Reader arg1);
		void setNString(int arg0, java.lang.String arg1);
		void setNCharacterStream(int arg0, java.io.Reader arg1, long arg2);
		void setNCharacterStream(int arg0, java.io.Reader arg1);
		void setNClob(int arg0, java.io.Reader arg1);
		void setNClob(int arg0, java.io.Reader arg1, long arg2);
		void setClob(int arg0, java.sql.Clob arg1);
		void setClob(int arg0, java.io.Reader arg1, long arg2);
		void setClob(int arg0, java.io.Reader arg1);
		void setBlob(int arg0, java.sql.Blob arg1);
		void setBlob(int arg0, java.io.InputStream arg1, long arg2);
		void setBlob(int arg0, java.io.InputStream arg1);
		global::java.sql.ResultSet executeQuery();
		int executeUpdate();
		void setUnicodeStream(int arg0, java.io.InputStream arg1, int arg2);
		void clearParameters();
		void setRef(int arg0, java.sql.Ref arg1);
		void setArray(int arg0, java.sql.Array arg1);
		global::java.sql.ParameterMetaData getParameterMetaData();
	}

	[global::MonoJavaBridge.JavaProxy(typeof(global::java.sql.PreparedStatement))]
	internal sealed partial class PreparedStatement_ : java.lang.Object, PreparedStatement
	{
		internal new static global::MonoJavaBridge.JniGlobalHandle staticClass;
		internal PreparedStatement_(global::MonoJavaBridge.JNIEnv @__env) : base(@__env)
		{
		}
		private static global::MonoJavaBridge.MethodId _m0;
		void java.sql.PreparedStatement.setBoolean(int arg0, bool arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBoolean", "(IZ)V", ref global::java.sql.PreparedStatement_._m0, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m1;
		void java.sql.PreparedStatement.setByte(int arg0, byte arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setByte", "(IB)V", ref global::java.sql.PreparedStatement_._m1, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m2;
		void java.sql.PreparedStatement.setShort(int arg0, short arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setShort", "(IS)V", ref global::java.sql.PreparedStatement_._m2, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m3;
		void java.sql.PreparedStatement.setInt(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setInt", "(II)V", ref global::java.sql.PreparedStatement_._m3, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m4;
		void java.sql.PreparedStatement.setLong(int arg0, long arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setLong", "(IJ)V", ref global::java.sql.PreparedStatement_._m4, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m5;
		void java.sql.PreparedStatement.setFloat(int arg0, float arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setFloat", "(IF)V", ref global::java.sql.PreparedStatement_._m5, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m6;
		void java.sql.PreparedStatement.setDouble(int arg0, double arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setDouble", "(ID)V", ref global::java.sql.PreparedStatement_._m6, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m7;
		void java.sql.PreparedStatement.setTimestamp(int arg0, java.sql.Timestamp arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;)V", ref global::java.sql.PreparedStatement_._m7, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m8;
		void java.sql.PreparedStatement.setTimestamp(int arg0, java.sql.Timestamp arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setTimestamp", "(ILjava/sql/Timestamp;Ljava/util/Calendar;)V", ref global::java.sql.PreparedStatement_._m8, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m9;
		void java.sql.PreparedStatement.setURL(int arg0, java.net.URL arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setURL", "(ILjava/net/URL;)V", ref global::java.sql.PreparedStatement_._m9, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m10;
		void java.sql.PreparedStatement.setTime(int arg0, java.sql.Time arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setTime", "(ILjava/sql/Time;Ljava/util/Calendar;)V", ref global::java.sql.PreparedStatement_._m10, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m11;
		void java.sql.PreparedStatement.setTime(int arg0, java.sql.Time arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setTime", "(ILjava/sql/Time;)V", ref global::java.sql.PreparedStatement_._m11, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m12;
		void java.sql.PreparedStatement.setDate(int arg0, java.sql.Date arg1, java.util.Calendar arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setDate", "(ILjava/sql/Date;Ljava/util/Calendar;)V", ref global::java.sql.PreparedStatement_._m12, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m13;
		void java.sql.PreparedStatement.setDate(int arg0, java.sql.Date arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setDate", "(ILjava/sql/Date;)V", ref global::java.sql.PreparedStatement_._m13, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m14;
		bool java.sql.PreparedStatement.execute()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "execute", "()Z", ref global::java.sql.PreparedStatement_._m14);
		}
		private static global::MonoJavaBridge.MethodId _m15;
		void java.sql.PreparedStatement.addBatch()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "addBatch", "()V", ref global::java.sql.PreparedStatement_._m15);
		}
		private static global::MonoJavaBridge.MethodId _m16;
		void java.sql.PreparedStatement.setString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setString", "(ILjava/lang/String;)V", ref global::java.sql.PreparedStatement_._m16, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m17;
		void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setObject", "(ILjava/lang/Object;I)V", ref global::java.sql.PreparedStatement_._m17, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m18;
		void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1, int arg2, int arg3)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setObject", "(ILjava/lang/Object;II)V", ref global::java.sql.PreparedStatement_._m18, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg3));
		}
		private static global::MonoJavaBridge.MethodId _m19;
		void java.sql.PreparedStatement.setObject(int arg0, java.lang.Object arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setObject", "(ILjava/lang/Object;)V", ref global::java.sql.PreparedStatement_._m19, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m20;
		global::java.sql.ResultSetMetaData java.sql.PreparedStatement.getMetaData()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSetMetaData>(this, global::java.sql.PreparedStatement_.staticClass, "getMetaData", "()Ljava/sql/ResultSetMetaData;", ref global::java.sql.PreparedStatement_._m20) as java.sql.ResultSetMetaData;
		}
		private static global::MonoJavaBridge.MethodId _m21;
		void java.sql.PreparedStatement.setBytes(int arg0, byte[] arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBytes", "(I[B)V", ref global::java.sql.PreparedStatement_._m21, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m22;
		void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;)V", ref global::java.sql.PreparedStatement_._m22, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m23;
		void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;I)V", ref global::java.sql.PreparedStatement_._m23, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m24;
		void java.sql.PreparedStatement.setBinaryStream(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBinaryStream", "(ILjava/io/InputStream;J)V", ref global::java.sql.PreparedStatement_._m24, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m25;
		void java.sql.PreparedStatement.setNull(int arg0, int arg1, java.lang.String arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setNull", "(IILjava/lang/String;)V", ref global::java.sql.PreparedStatement_._m25, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m26;
		void java.sql.PreparedStatement.setNull(int arg0, int arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setNull", "(II)V", ref global::java.sql.PreparedStatement_._m26, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m27;
		void java.sql.PreparedStatement.setBigDecimal(int arg0, java.math.BigDecimal arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBigDecimal", "(ILjava/math/BigDecimal;)V", ref global::java.sql.PreparedStatement_._m27, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m28;
		void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;I)V", ref global::java.sql.PreparedStatement_._m28, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m29;
		void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;)V", ref global::java.sql.PreparedStatement_._m29, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m30;
		void java.sql.PreparedStatement.setAsciiStream(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setAsciiStream", "(ILjava/io/InputStream;J)V", ref global::java.sql.PreparedStatement_._m30, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m31;
		void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;I)V", ref global::java.sql.PreparedStatement_._m31, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m32;
		void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;J)V", ref global::java.sql.PreparedStatement_._m32, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m33;
		void java.sql.PreparedStatement.setCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setCharacterStream", "(ILjava/io/Reader;)V", ref global::java.sql.PreparedStatement_._m33, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m34;
		void java.sql.PreparedStatement.setNString(int arg0, java.lang.String arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setNString", "(ILjava/lang/String;)V", ref global::java.sql.PreparedStatement_._m34, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m35;
		void java.sql.PreparedStatement.setNCharacterStream(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;J)V", ref global::java.sql.PreparedStatement_._m35, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m36;
		void java.sql.PreparedStatement.setNCharacterStream(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setNCharacterStream", "(ILjava/io/Reader;)V", ref global::java.sql.PreparedStatement_._m36, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m37;
		void java.sql.PreparedStatement.setNClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setNClob", "(ILjava/io/Reader;)V", ref global::java.sql.PreparedStatement_._m37, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m38;
		void java.sql.PreparedStatement.setNClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setNClob", "(ILjava/io/Reader;J)V", ref global::java.sql.PreparedStatement_._m38, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m39;
		void java.sql.PreparedStatement.setClob(int arg0, java.sql.Clob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setClob", "(ILjava/sql/Clob;)V", ref global::java.sql.PreparedStatement_._m39, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m40;
		void java.sql.PreparedStatement.setClob(int arg0, java.io.Reader arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setClob", "(ILjava/io/Reader;J)V", ref global::java.sql.PreparedStatement_._m40, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m41;
		void java.sql.PreparedStatement.setClob(int arg0, java.io.Reader arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setClob", "(ILjava/io/Reader;)V", ref global::java.sql.PreparedStatement_._m41, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m42;
		void java.sql.PreparedStatement.setBlob(int arg0, java.sql.Blob arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBlob", "(ILjava/sql/Blob;)V", ref global::java.sql.PreparedStatement_._m42, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m43;
		void java.sql.PreparedStatement.setBlob(int arg0, java.io.InputStream arg1, long arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBlob", "(ILjava/io/InputStream;J)V", ref global::java.sql.PreparedStatement_._m43, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m44;
		void java.sql.PreparedStatement.setBlob(int arg0, java.io.InputStream arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setBlob", "(ILjava/io/InputStream;)V", ref global::java.sql.PreparedStatement_._m44, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m45;
		global::java.sql.ResultSet java.sql.PreparedStatement.executeQuery()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.PreparedStatement_.staticClass, "executeQuery", "()Ljava/sql/ResultSet;", ref global::java.sql.PreparedStatement_._m45) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m46;
		int java.sql.PreparedStatement.executeUpdate()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "()I", ref global::java.sql.PreparedStatement_._m46);
		}
		private static global::MonoJavaBridge.MethodId _m47;
		void java.sql.PreparedStatement.setUnicodeStream(int arg0, java.io.InputStream arg1, int arg2)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setUnicodeStream", "(ILjava/io/InputStream;I)V", ref global::java.sql.PreparedStatement_._m47, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg2));
		}
		private static global::MonoJavaBridge.MethodId _m48;
		void java.sql.PreparedStatement.clearParameters()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "clearParameters", "()V", ref global::java.sql.PreparedStatement_._m48);
		}
		private static global::MonoJavaBridge.MethodId _m49;
		void java.sql.PreparedStatement.setRef(int arg0, java.sql.Ref arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setRef", "(ILjava/sql/Ref;)V", ref global::java.sql.PreparedStatement_._m49, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m50;
		void java.sql.PreparedStatement.setArray(int arg0, java.sql.Array arg1)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setArray", "(ILjava/sql/Array;)V", ref global::java.sql.PreparedStatement_._m50, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m51;
		global::java.sql.ParameterMetaData java.sql.PreparedStatement.getParameterMetaData()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ParameterMetaData>(this, global::java.sql.PreparedStatement_.staticClass, "getParameterMetaData", "()Ljava/sql/ParameterMetaData;", ref global::java.sql.PreparedStatement_._m51) as java.sql.ParameterMetaData;
		}
		private static global::MonoJavaBridge.MethodId _m52;
		void java.sql.Statement.close()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "close", "()V", ref global::java.sql.PreparedStatement_._m52);
		}
		private static global::MonoJavaBridge.MethodId _m53;
		bool java.sql.Statement.isClosed()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "isClosed", "()Z", ref global::java.sql.PreparedStatement_._m53);
		}
		private static global::MonoJavaBridge.MethodId _m54;
		bool java.sql.Statement.execute(java.lang.String arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;[I)Z", ref global::java.sql.PreparedStatement_._m54, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m55;
		bool java.sql.Statement.execute(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;I)Z", ref global::java.sql.PreparedStatement_._m55, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m56;
		bool java.sql.Statement.execute(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;)Z", ref global::java.sql.PreparedStatement_._m56, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m57;
		bool java.sql.Statement.execute(java.lang.String arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "execute", "(Ljava/lang/String;[Ljava/lang/String;)Z", ref global::java.sql.PreparedStatement_._m57, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m58;
		void java.sql.Statement.cancel()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "cancel", "()V", ref global::java.sql.PreparedStatement_._m58);
		}
		private static global::MonoJavaBridge.MethodId _m59;
		void java.sql.Statement.addBatch(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "addBatch", "(Ljava/lang/String;)V", ref global::java.sql.PreparedStatement_._m59, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m60;
		global::java.sql.Connection java.sql.Statement.getConnection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.Connection>(this, global::java.sql.PreparedStatement_.staticClass, "getConnection", "()Ljava/sql/Connection;", ref global::java.sql.PreparedStatement_._m60) as java.sql.Connection;
		}
		private static global::MonoJavaBridge.MethodId _m61;
		global::java.sql.ResultSet java.sql.Statement.getResultSet()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.PreparedStatement_.staticClass, "getResultSet", "()Ljava/sql/ResultSet;", ref global::java.sql.PreparedStatement_._m61) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m62;
		global::java.sql.SQLWarning java.sql.Statement.getWarnings()
		{
			return global::MonoJavaBridge.JavaBridge.CallObjectMethod(this, global::java.sql.PreparedStatement_.staticClass, "getWarnings", "()Ljava/sql/SQLWarning;", ref global::java.sql.PreparedStatement_._m62) as java.sql.SQLWarning;
		}
		private static global::MonoJavaBridge.MethodId _m63;
		void java.sql.Statement.clearWarnings()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "clearWarnings", "()V", ref global::java.sql.PreparedStatement_._m63);
		}
		private static global::MonoJavaBridge.MethodId _m64;
		void java.sql.Statement.setFetchDirection(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setFetchDirection", "(I)V", ref global::java.sql.PreparedStatement_._m64, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m65;
		int java.sql.Statement.getFetchDirection()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getFetchDirection", "()I", ref global::java.sql.PreparedStatement_._m65);
		}
		private static global::MonoJavaBridge.MethodId _m66;
		void java.sql.Statement.setFetchSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setFetchSize", "(I)V", ref global::java.sql.PreparedStatement_._m66, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m67;
		int java.sql.Statement.getFetchSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getFetchSize", "()I", ref global::java.sql.PreparedStatement_._m67);
		}
		private static global::MonoJavaBridge.MethodId _m68;
		global::java.sql.ResultSet java.sql.Statement.executeQuery(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.PreparedStatement_.staticClass, "executeQuery", "(Ljava/lang/String;)Ljava/sql/ResultSet;", ref global::java.sql.PreparedStatement_._m68, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0)) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m69;
		int java.sql.Statement.executeUpdate(java.lang.String arg0, int arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;I)I", ref global::java.sql.PreparedStatement_._m69, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m70;
		int java.sql.Statement.executeUpdate(java.lang.String arg0, int[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;[I)I", ref global::java.sql.PreparedStatement_._m70, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m71;
		int java.sql.Statement.executeUpdate(java.lang.String arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;)I", ref global::java.sql.PreparedStatement_._m71, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m72;
		int java.sql.Statement.executeUpdate(java.lang.String arg0, java.lang.String[] arg1)
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "executeUpdate", "(Ljava/lang/String;[Ljava/lang/String;)I", ref global::java.sql.PreparedStatement_._m72, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0), global::MonoJavaBridge.JavaBridge.ConvertToValue(arg1));
		}
		private static global::MonoJavaBridge.MethodId _m73;
		int java.sql.Statement.getMaxFieldSize()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getMaxFieldSize", "()I", ref global::java.sql.PreparedStatement_._m73);
		}
		private static global::MonoJavaBridge.MethodId _m74;
		void java.sql.Statement.setMaxFieldSize(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setMaxFieldSize", "(I)V", ref global::java.sql.PreparedStatement_._m74, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m75;
		int java.sql.Statement.getMaxRows()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getMaxRows", "()I", ref global::java.sql.PreparedStatement_._m75);
		}
		private static global::MonoJavaBridge.MethodId _m76;
		void java.sql.Statement.setMaxRows(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setMaxRows", "(I)V", ref global::java.sql.PreparedStatement_._m76, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m77;
		void java.sql.Statement.setEscapeProcessing(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setEscapeProcessing", "(Z)V", ref global::java.sql.PreparedStatement_._m77, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m78;
		int java.sql.Statement.getQueryTimeout()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getQueryTimeout", "()I", ref global::java.sql.PreparedStatement_._m78);
		}
		private static global::MonoJavaBridge.MethodId _m79;
		void java.sql.Statement.setQueryTimeout(int arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setQueryTimeout", "(I)V", ref global::java.sql.PreparedStatement_._m79, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m80;
		void java.sql.Statement.setCursorName(java.lang.String arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setCursorName", "(Ljava/lang/String;)V", ref global::java.sql.PreparedStatement_._m80, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m81;
		int java.sql.Statement.getUpdateCount()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getUpdateCount", "()I", ref global::java.sql.PreparedStatement_._m81);
		}
		private static global::MonoJavaBridge.MethodId _m82;
		bool java.sql.Statement.getMoreResults()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "getMoreResults", "()Z", ref global::java.sql.PreparedStatement_._m82);
		}
		private static global::MonoJavaBridge.MethodId _m83;
		bool java.sql.Statement.getMoreResults(int arg0)
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "getMoreResults", "(I)Z", ref global::java.sql.PreparedStatement_._m83, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m84;
		int java.sql.Statement.getResultSetConcurrency()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getResultSetConcurrency", "()I", ref global::java.sql.PreparedStatement_._m84);
		}
		private static global::MonoJavaBridge.MethodId _m85;
		int java.sql.Statement.getResultSetType()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getResultSetType", "()I", ref global::java.sql.PreparedStatement_._m85);
		}
		private static global::MonoJavaBridge.MethodId _m86;
		void java.sql.Statement.clearBatch()
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "clearBatch", "()V", ref global::java.sql.PreparedStatement_._m86);
		}
		private static global::MonoJavaBridge.MethodId _m87;
		int[] java.sql.Statement.executeBatch()
		{
			return global::MonoJavaBridge.JavaBridge.CallArrayObjectMethod<int>(this, global::java.sql.PreparedStatement_.staticClass, "executeBatch", "()[I", ref global::java.sql.PreparedStatement_._m87) as int[];
		}
		private static global::MonoJavaBridge.MethodId _m88;
		global::java.sql.ResultSet java.sql.Statement.getGeneratedKeys()
		{
			return global::MonoJavaBridge.JavaBridge.CallIJavaObjectMethod<java.sql.ResultSet>(this, global::java.sql.PreparedStatement_.staticClass, "getGeneratedKeys", "()Ljava/sql/ResultSet;", ref global::java.sql.PreparedStatement_._m88) as java.sql.ResultSet;
		}
		private static global::MonoJavaBridge.MethodId _m89;
		int java.sql.Statement.getResultSetHoldability()
		{
			return global::MonoJavaBridge.JavaBridge.CallIntMethod(this, global::java.sql.PreparedStatement_.staticClass, "getResultSetHoldability", "()I", ref global::java.sql.PreparedStatement_._m89);
		}
		private static global::MonoJavaBridge.MethodId _m90;
		void java.sql.Statement.setPoolable(bool arg0)
		{
			global::MonoJavaBridge.JavaBridge.CallVoidMethod(this, global::java.sql.PreparedStatement_.staticClass, "setPoolable", "(Z)V", ref global::java.sql.PreparedStatement_._m90, global::MonoJavaBridge.JavaBridge.ConvertToValue(arg0));
		}
		private static global::MonoJavaBridge.MethodId _m91;
		bool java.sql.Statement.isPoolable()
		{
			return global::MonoJavaBridge.JavaBridge.CallBooleanMethod(this, global::java.sql.PreparedStatement_.staticClass, "isPoolable", "()Z", ref global::java.sql.PreparedStatement_._m91);
		}
		static PreparedStatement_()
		{
			global::MonoJavaBridge.JNIEnv @__env = global::MonoJavaBridge.JNIEnv.ThreadEnv;
			global::java.sql.PreparedStatement_.staticClass = @__env.NewGlobalRef(@__env.FindClass("java/sql/PreparedStatement"));
		}
	}
}
